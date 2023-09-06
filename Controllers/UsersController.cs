using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NuGet.Common;
using Org.BouncyCastle.Bcpg.Sig;
using server;
using server.DTO;
using server.DTO.User;
using server.Helpers;
using server.Models;
using server.ViewModels;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private readonly PhotosContainer _container;
        private readonly Regex DataUriPattern = new(@"^data\:(?<type>image\/(png|tiff|jpg|gif|jpeg));base64,(?<data>[A-Z0-9\+\/\=]+)$", RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
        public UsersController(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _container = new PhotosContainer();
        }
        [HttpPost("updateinfo")]
        public async Task<ActionResult> UpdateInfo([FromBody] UpdateInfo updateInfo)
        {
            if (updateInfo.Token != null)
            {
                if (await TokenGen.ValidateCurrentToken(updateInfo.Token))
                {
                    if (!await _context.Users.AnyAsync(u => u.Id == updateInfo.Id))
                    {
                        return NotFound(new { message = "User not found" });
                    }
                    else
                    {
                        User? user = await _context.Users.FirstOrDefaultAsync
                       (u => u.Id == updateInfo.Id, CancellationToken.None);
                        if (user != null)
                        {
                            List<ChatUpdateInfoViewModel>? chats = new();
                            List<UserViewModel>? contacts = new();
                            User? temp;
                            Chat? tempc;
                            UserChat tempUc;
                            ChatUpdateInfoViewModel tempcvm;
                            List<string> tempshort;
                            foreach (UserContact ch in _context.UserContacts)
                            {
                                if (ch.UserId == user.Id)
                                {
                                    temp = await _context.Users.FirstOrDefaultAsync(us => us.Id == ch.ContactId);
                                    if (temp != null)
                                    {
                                        contacts.Add(_mapper.Map<UserViewModel>(temp));
                                    }
                                }
                            }
                            foreach (UserChat ch in _context.UserChats)
                            {
                                if (ch.UserId == user.Id)
                                {
                                    tempc = await _context.Chats.FirstAsync(c => c.Id == ch.ChatId);
                                    if (tempc != null)
                                    {
                                        if (tempc.ShortMessage != null)
                                        {
                                            try
                                            {
                                                if (tempc.Type == "Private")
                                                {
                                                    tempUc = await _context.UserChats.FirstAsync(uc => uc.ChatId == ch.ChatId && uc.UserId != ch.UserId);
                                                    temp = await _context.Users.FirstAsync(u => u.Id == tempUc.UserId);

                                                    tempc.ChatName = temp.UserName;
                                                    if (temp.Photo != null)
                                                    {
                                                        tempc.ChatImage = temp.Photo;
                                                    }
                                                    else tempc.ChatImage = null;
                                                    _context.Entry(tempc).State = EntityState.Modified;
                                                }
                                                tempcvm = _mapper.Map<ChatUpdateInfoViewModel>(tempc);
                                                if (tempc.ShortMessage.Contains(':'))
                                                {
                                                    tempshort = tempc.ShortMessage.Split(':').ToList();
                                                    temp = await _context.Users.FirstOrDefaultAsync(u => u.UserName == tempshort[0]);

                                                    if (temp != null)
                                                    {
                                                        tempcvm.ShortMsg = new ShortMessg
                                                        {
                                                            UserId = temp.Id,
                                                            Message = tempc.ShortMessage.Substring(tempshort[0].Length + 1),
                                                            Username = temp.UserName
                                                        };
                                                    }
                                                    else
                                                    {
                                                        tempcvm.ShortMsg = new ShortMessg
                                                        {
                                                            UserId = tempc.AuthorId,
                                                            Message = tempc.ShortMessage.Substring(tempshort[0].Length + 1),
                                                            Username = tempc.ChatName
                                                        };
                                                    }

                                                }
                                                else
                                                {
                                                    if (tempc.Type == "Favorite")
                                                    {
                                                        tempcvm.ShortMsg = new ShortMessg
                                                        {
                                                            UserId = null,
                                                            Message = tempc.ShortMessage,
                                                            Username = tempc.ChatName
                                                        };
                                                    }
                                                    else if (tempc.Type == "Private")
                                                    {
                                                        tempcvm.ShortMsg = new ShortMessg
                                                        {
                                                            UserId = null,
                                                            Message = tempc.ShortMessage,
                                                            Username = null
                                                        };
                                                    }
                                                    else
                                                    {
                                                        tempcvm.ShortMsg = new ShortMessg
                                                        {
                                                            UserId = null,
                                                            Message = tempc.ShortMessage,
                                                            Username = tempc.ChatName
                                                        };
                                                    }
                                                }
                                                tempcvm.NotViewedCounter = await GetUnreadedMessages(ch.ChatId, user.Id);
                                                tempcvm.WhoMuted = new List<int>();
                                                await _context.ChatMutes.ForEachAsync(cm =>
                                                {
                                                    if (cm.ChatId == ch.ChatId) tempcvm.WhoMuted.Add(cm.UserId);
                                                });
                                                tempcvm.Members = await GetChatMembers(tempcvm.Id);
                                                chats.Add(tempcvm);
                                            }
                                            catch (DbUpdateException ex)
                                            {
                                                Console.WriteLine(ex.InnerException?.Message);
                                            }
                                        }
                                    }
                                }
                            }
                            UserViewModel uvm = _mapper.Map<UserViewModel>(user);
                            await _context.SaveChangesAsync();
                            UpdateLastOnline(user);
                            return Ok(new { user = uvm, chats, contacts });
                        }
                    }
                }
                return BadRequest(new { error = "Token is not valid" });
            }
            return BadRequest(new { error = "Token was null" });
        }
        
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register([FromBody] UserRegister model)
        {
            if (!await _context.Users.AnyAsync(u => u.UserName == model.UserName))
            {
                if (!await _context.Users.AnyAsync(u => u.Email == model.Email))
                {
                    if (model.Password == null || model.Password.Length < 1) return BadRequest(new {error="Password was null"});
                    //add user
                    string hashedPassword = HashHelper.HashPassword(model.Password);
                    var user = new User
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        Password = hashedPassword,
                        MemberId = 1,
                        LastOnline= DateTime.Now
                    };
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();

                    User temp = await _context.Users.FirstAsync(u => u.UserName == model.UserName);
                    //add saved chat
                    var savedChat = new Chat
                    {
                        MembersCount = 1,
                        ChatName = "Saved Messages",
                        ShortMessage = "Saved Messages",
                        AuthorId = temp.Id,
                        Type = "Favorite",
                        ChatImage = _container.SavedMessageImage
                    };
                    _context.Chats.Add(savedChat);
                    await _context.SaveChangesAsync();

                    Chat tempc = await _context.Chats.FirstAsync(c => c.AuthorId == temp.Id);
                    //add userchats
                    var userChat = new UserChat
                    {
                        UserId = temp.Id,
                        ChatId = tempc.Id
                    };
                    _context.UserChats.Add(userChat);
                    await _context.SaveChangesAsync();
                    List<ChatViewModel>? chats = new();
                    foreach (UserChat ch in _context.UserChats)
                    {
                        if (ch.UserId == user.Id)
                        {
                            chats.Add(_mapper.Map<ChatViewModel>(await _context.Chats.FirstAsync(c => c.Id == ch.ChatId)));
                        }
                    }
                    UserViewModel uvm = _mapper.Map<UserViewModel>(user);
                    var token = TokenGen.GenerateToken(user.Id);
                    return Ok(new { jwtToken = token, user=uvm, chats });
                }
                else return BadRequest(new { error = "Email is already used" });
            }
            else return BadRequest(new { error = "Username is already used" });
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserLogin>> Login([FromBody] UserLogin model)
        {
            if (model.Password == null) return BadRequest(new {error="Password was null"});
            if(model.Login == null) return BadRequest(new { error = "Login was null" });
            bool passwordverify = false;
            if (model.Login.Length == 0 || model.Password.Length == 0)
            {
                return BadRequest(new { message = "Please, fill the auth fields." });
            }
            if (!_context.Users.Any(u => u.UserName == model.Login || u.Email == model.Login))
            {
                return NotFound(new { message = "User not found" });
            }
            else if (!_context.Users.Any(u => u.UserName == model.Login || u.Email == model.Login))
            {
                return BadRequest(new { message = "Username is incorrect." });
            }
            User? user = await _context.Users.FirstAsync
                (u => u.UserName == model.Login || u.Email == model.Login);
            passwordverify = HashHelper.VerifyHashedPassword(user.Password,model.Password);
            if (passwordverify == false) return BadRequest(new { message = "Password is incorrect" });
            UserViewModel uvm = _mapper.Map<UserViewModel>(user);
            User? temp;
            Chat? tempc;
            if (user != null)
            {
                var token = TokenGen.GenerateToken(user.Id);
                List<ChatViewModel>? chats = new();
                List<UserViewModel>? contacts = new();
                UserChat tempUc;
                ChatViewModel tempcvm;
                foreach (UserContact ch in _context.UserContacts)
                {
                    if (ch.UserId == user.Id)
                    {
                        temp = await _context.Users.FirstOrDefaultAsync(u => u.Id == ch.ContactId);
                        if(temp!=null)
                        contacts.Add(_mapper.Map<UserViewModel>(temp));
                    }
                }
                foreach (UserChat ch in _context.UserChats)
                {
                    if (ch.UserId == user.Id)
                    {
                        tempc = await _context.Chats.FirstAsync(c => c.Id == ch.ChatId);
                        if (tempc != null)
                        {
                            if (tempc.Type == "Private")
                            {
                                tempUc = await _context.UserChats.FirstAsync(uc=>uc.ChatId==ch.ChatId && uc.UserId!=ch.UserId);
                                temp = await _context.Users.FirstAsync(u=>u.Id == tempUc.UserId);
                                
                                tempc.ChatName = temp.UserName;
                            }
                            tempcvm = _mapper.Map<ChatViewModel>(tempc);
                                tempcvm.NotViewedCounter = await GetUnreadedMessages(ch.ChatId, user.Id);
                            chats.Add(tempcvm);
                        }
                    }
                }
                UpdateLastOnline(user);
                return Ok(new { jwtToken = token, user=uvm,  chats, contacts });
            }
            else return BadRequest();
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [Authorize]
        [HttpPost("username/id")]
        public async Task<ActionResult> GetIdByLogin([FromBody] GetUserId us)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == us.Login || u.Email == us.Login);

            if (user == null)
            {
                return NotFound(new {error="User not found..."});
            }

            return Ok(new { id = user.Id, username=user.UserName, email=user.Email });
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound(new {error="User not found"});
            }

            UserViewModel uvm = _mapper.Map<UserViewModel>(user);
            return Ok(new { user = uvm });
        }

        [Authorize]
        [HttpGet("username/{userName}")]
        public async Task<ActionResult<User>> GetUserByUserName(string userName)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName, CancellationToken.None);

            if (user == null)
            {
                return NotFound();
            }
            UserViewModel uvm = _mapper.Map<UserViewModel>(user);
            return Ok(new {user=uvm});
        }

        [Authorize]
        [HttpPatch("patchuser")]
        public async Task<IActionResult> PatchUser([FromBody]PatchUser pu)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u=>u.Id == pu.Id);
            if (user == null) return NotFound(new {error="User not found."});
            if (pu.About != null)
            {
                if (pu.About.Length > 0)
                user.AboutUser = pu.About;
            }
            if (pu.UserName != null)
            {
                if (pu.UserName.Length > 0)
                {
                    if (user.UserName != pu.UserName)
                    {
                        if (!await _context.Users.AnyAsync(u => u.UserName == pu.UserName))
                        {
                            user.UserName = pu.UserName;
                        }
                        else return BadRequest(new { error = "Username is already used!" });
                    }
                }
            }
            if (pu.Age != null)
            {
                user.Age = Convert.ToInt32(pu.Age);
            }
            if (pu.Email != null)
            {
                if (pu.Email.Length > 0)
                {
                    if (pu.Email != user.Email)
                    {
                        if (!await _context.Users.AnyAsync(u => u.Email == pu.Email))
                        {
                            user.Email = pu.Email;
                        }
                        else return BadRequest(new { error = "Email is already used" });
                    }
                }
            }
            if(pu.Photo != null)
            {
                Match match = DataUriPattern.Match(pu.Photo);
                if (match.Success)
                    user.Photo = pu.Photo;
                else return BadRequest(new {error="Invalid base64 image string." });
            }
            try
            {
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                UpdateLastOnline(user);
                UserViewModel uvm = _mapper.Map<UserViewModel>(user);
                return Ok(new { user=uvm });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPatch("setpassword")]
        public async Task<IActionResult> SetPassword([FromBody]ResetPassword rUser)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u=>u.Email == rUser.Email);
            if (user != null)
            {
                if (rUser.newPassword == null || rUser.newPassword.Length<1) return BadRequest(new { error = "Password was null" });
                user.Password = HashHelper.HashPassword(rUser.newPassword);
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                UpdateLastOnline(user);
                UserViewModel uvm = _mapper.Map<UserViewModel>(user);
                return Ok(new { result = "success", user=uvm });
            }
            else return NotFound(new { error = "User not found" });
        }
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
           // _userManager.CreateAsync(new UserLogin { Email = user.Email, Password = user.Password, Login = user.UserName });
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        [HttpGet("test/{id}")]
        public async Task<ActionResult<User>> test(int id)
        {
            return Ok("this is working");
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private async void UpdateLastOnline(User user)
        {
            try
            {
                user.LastOnline = DateTime.Now;
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
            }

        }
        private async Task<int> GetUnreadedMessages(int chatId, int userId)
        {
            int counter = 0;
            Message? temp = null;
            foreach (ChatMessage item in _context.ChatMessages.Where(cm=>cm.ChatId==chatId))
            {
                temp = _context.Messages.FirstOrDefault(m=>m.Id==item.MessageId);
                if (temp != null)
                {
                    if (!await _context.MessageViews.AnyAsync(mv=>mv.UserId== userId && mv.MessageId==item.MessageId)) counter++;
                }
            }
            return counter;
        }
        private async Task<List<int>> GetChatMembers(int chatId)
        {
            List<int> members = new();
            await _context.UserChats.Where(cm => cm.ChatId == chatId).ForEachAsync(item =>
            {
                members.Add(item.UserId);
            });
            return members;
        }
    }
}
