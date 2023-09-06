using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server;
using server.DTO.Chat;
using server.Models;
using server.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper; 
        private readonly Regex DataUriPattern = new(@"^data\:(?<type>image\/(png|tiff|jpg|gif|jpeg));base64,(?<data>[A-Z0-9\+\/\=]+)$", RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
        public ChatsController(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [Authorize]
        [HttpPatch("setpinnedmessage")]
        public async Task<ActionResult> SetPinned([FromBody] SetPinnedMessage pinnedMessage)
        {
            if (pinnedMessage == null) return BadRequest(new { error = "Request was null" });
            if (pinnedMessage.Action != null)
            {
                if(pinnedMessage.Action == "Set")
                {
                    Message? m = await _context.Messages.FirstOrDefaultAsync(ms => ms.Id == pinnedMessage.MessageId);
                    if (m == null) return NotFound(new { error = "Message not found." });
                    User? u = await _context.Users.FirstOrDefaultAsync(us => us.Id == m.UserId);
                    if (m != null)
                    {
                        ChatMessage? cm = await _context.ChatMessages.FirstOrDefaultAsync(chm => chm.ChatId == pinnedMessage.ChatId && chm.MessageId == m.Id);
                        if (cm != null)
                        {
                            Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == pinnedMessage.ChatId);
                            if (c != null)
                            {
                                c.PinnedMessageId = pinnedMessage.MessageId;
                                try
                                {
                                    _context.Entry(c).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                }
                                catch (Exception ex)
                                {
                                    return BadRequest(new { error = "Db saving changes error.", ex });
                                }
                                ChatViewModel cvm = _mapper.Map<ChatViewModel>(c);

                                return Ok(new {result="Success",chat = cvm});
                            }
                        }
                        else return BadRequest(new { error = "Message are not in this chat." });

                    }
                    else return BadRequest(new { error = "Message not found" });
                }
                if (pinnedMessage.Action == "Remove")
                {
                    Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == pinnedMessage.ChatId);
                    if (c != null)
                    {
                        c.PinnedMessageId = null;
                        try
                        {
                            _context.Chats.Entry(c).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            return BadRequest(new { error = "Db saving changes error.", ex });
                        }
                        ChatViewModel cvm = _mapper.Map<ChatViewModel>(c);
                        return Ok(new { result = "Success", chat = cvm });
                    }
                }
                else return BadRequest(new { error = "Invalid action" });
            }
            return BadRequest(new { error = "Action was null" });
        }
        [Authorize]
        [HttpPost("chatexists")]
        public async Task<IActionResult> ChatExist([FromBody] ChatExists ce)
        {
            bool exists = false;
            int tempid = 0;
            Chat? c;
            foreach (UserChat item in _context.UserChats)
            {
                if (item.UserId == ce.UserId)
                {
                    c = await _context.Chats.FirstAsync(ch => ch.Id == item.ChatId);
                    if (c.Type == "Private")
                    {
                        tempid = item.ChatId;
                        foreach (UserChat uc in _context.UserChats.Where(cv => cv.ChatId == item.ChatId))
                        {
                            if (uc.UserId == ce.OpponentId) exists = true;
                        }
                    }
                }
            }
            return Ok(new { exists });
        }
        [Authorize]
        [HttpPost("enterpublicchat")]
        public async Task<ActionResult> EnterPublicChat([FromBody]EnterPublicChat chat)
        {
            if (chat != null)
            {
                if (chat.ChatName != null)
                {
                    Chat? c = await _context.Chats.FirstOrDefaultAsync(ch=>ch.ChatName==chat.ChatName);
                    User? u = await _context.Users.FirstOrDefaultAsync(us => us.UserName == chat.UserName);
                    if (u != null && c != null)
                    {
                        UserChat uc = new ()
                        {
                            UserId = u.Id,
                            ChatId = c.Id
                        };

                        if (!await _context.UserChats.AnyAsync(uch => uch.UserId == uc.UserId && uch.ChatId == uc.ChatId))
                        {
                            await _context.UserChats.AddAsync(uc);
                            c.MembersCount += 1;
                            if (c.Type == "Group")
                            {
                                Message sysmsg = new()
                                {
                                    UserId = 745,
                                    SendTime = DateTime.Now,
                                    DeliveryStatus = true,
                                    Text = $"{u.UserName} has joined the {c.ChatName}"
                                };
                                await _context.Messages.AddAsync(sysmsg);
                                await _context.SaveChangesAsync();
                                sysmsg = await _context.Messages.FirstAsync(msg => msg.UserId == 745 && msg.Text == $"{u.UserName} has joined the {c.ChatName}");
                                ChatMessage syscmsg = new()
                                {
                                    ChatId = c.Id,
                                    MessageId = sysmsg.Id
                                };
                                await _context.ChatMessages.AddAsync(syscmsg);
                            }
                            _context.Entry(c).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            UpdateLastOnline(u);

                            List<UserViewModel> members = new();
                            foreach (UserChat userChat in _context.UserChats.Where(uc => uc.ChatId == c.Id))
                            {
                                u = await _context.Users.FirstAsync(u => u.Id == userChat.UserId);
                                members.Add(_mapper.Map<UserViewModel>(u));
                            }
                            ChatViewModel cvm = _mapper.Map<ChatViewModel>(c);
                            cvm.Members = await GetChatMembers(cvm.Id);
                            UserChatViewModel ucvm = _mapper.Map<UserChatViewModel>(uc);
                            return Ok(new { result = "success", uc=ucvm, chat = cvm});
                        }
                        return BadRequest(new {error="User already in this chat..."});
                    }
                    
                    else return NotFound(new {error="user or chat not found"});
                }
            }
            return BadRequest(new {error="Request was null"});
        }
        [Authorize]
        [HttpPost("openpublicchat")]
        public async Task<ActionResult> OpenPublicChat([FromBody] OpenChat oc)
        {
            if (oc != null)
            {
                if (oc.AuthorId != null && oc.ChatName != null)
                {
                    Chat? chat = await _context.Chats.FirstOrDefaultAsync(c => c.AuthorId == oc.AuthorId && c.ChatName == oc.ChatName);
                    List<UserViewModel> members = new();
                    Message tempm;
                    User tempu;
                    List<ReplyMessage> replyMessages = new();
                    UserMessageViewModel tempusvm;
                    List<UserMessageViewModel> messages = new();
                    if (chat != null)
                    {
                        foreach (ChatMessage item in _context.ChatMessages.Where(cm => cm.ChatId == chat.Id))
                        {
                            tempm = await _context.Messages.FirstAsync(m => m.Id == item.MessageId);
                            tempusvm = _mapper.Map<UserMessageViewModel>(tempm);
                            tempusvm.WhoViewed = new List<int>();
                            tempu = await _context.Users.FirstAsync(u => u.Id == tempm.UserId);
                            tempusvm.Author = _mapper.Map<UserViewModel>(tempu);
                            await _context.MessageViews.ForEachAsync(mv =>
                            {
                                if (mv.MessageId == item.MessageId)
                                {
                                    tempusvm.WhoViewed.Add(mv.UserId);
                                }
                            });
                            messages.Add(tempusvm); 
                            foreach (ReplyMessage replym in _context.ReplyMessages.Where(rm => rm.MessageId == tempm.Id))
                            {
                                replyMessages.Add(replym);
                            }
                        }
                        foreach (UserChat userChat in _context.UserChats.Where(uc => uc.ChatId == chat.Id))
                        {
                            tempu = await _context.Users.FirstAsync(u => u.Id == userChat.UserId);
                            members.Add(_mapper.Map<UserViewModel>(tempu));

                        }
                        ChatViewModel cvm = _mapper.Map<ChatViewModel>(chat);
                        cvm.Members = await GetChatMembers(cvm.Id);
                        return Ok(new { chat = cvm, messages, members, replyMessages });
                    }
                    else return BadRequest(new { error = "Chat not found." });
                }
                return BadRequest(new { error = "Invalid request." });
            }
            else return BadRequest(new {error="Invalid request."});
           
        }
        [Authorize]
        [HttpPost("openprivatechat")]
        public async Task<ActionResult> OpenPrivateChat([FromBody] OpenPrivateChat oc)
        {
            if (oc != null)
            {
                if (oc.CurrentUserId != 0 && oc.OpponentId!=0)
                {
                    User user1 = await _context.Users.FirstAsync(u => u.Id == oc.OpponentId);
                    User user2 = await _context.Users.FirstAsync(u => u.Id == oc.CurrentUserId);
                    Chat temp;
                    int chatid = 0;
                    foreach (UserChat item in _context.UserChats.Where(uc => uc.UserId == user1.Id || uc.UserId == user2.Id))
                    {
                        temp = await _context.Chats.FirstAsync(c => c.Id == item.ChatId);
                        if (temp.Type == "Private")
                        {
                            if (item.UserId == user1.Id)
                            {
                                if (_context.UserChats.Contains(new UserChat { ChatId = item.ChatId, UserId = user2.Id }))
                                {
                                    chatid = item.ChatId;
                                }
                            }
                            else if (item.UserId == user2.Id)
                            {
                                if (_context.UserChats.Contains(new UserChat { ChatId = item.ChatId, UserId = user1.Id }))
                                {
                                    chatid = item.ChatId;
                                }
                            }
                        }
                    }
                    if (chatid != 0)
                    {
                        Chat? chat = await _context.Chats.FirstOrDefaultAsync(c => c.Id == chatid);
                        if (chat == null) return NotFound(new { error = "Chat not found." });
                        chat.ChatName = user1.UserName;
                        if (user1.Photo != null)
                        {
                            chat.ChatImage = user1.Photo;
                        }
                        else chat.ChatImage = null;
                        _context.Entry(chat).State = EntityState.Modified;
                        List<UserViewModel> members = new();
                        Message tempm;
                        User tempu;
                        UserMessageViewModel tempusvm;
                        List<ReplyMessage> replyMessages = new();
                        List<UserMessageViewModel> messages = new();
                        if (chat != null)
                        {
                            foreach (ChatMessage item in _context.ChatMessages.Where(cm => cm.ChatId == chat.Id))
                            {
                                tempm = await _context.Messages.FirstAsync(m => m.Id == item.MessageId);
                                tempusvm = _mapper.Map<UserMessageViewModel>(tempm);
                                tempu = await _context.Users.FirstAsync(u => u.Id == tempm.UserId);
                                tempusvm.Author = _mapper.Map<UserViewModel>(tempu);
                                tempusvm.WhoViewed = new List<int>();
                                await _context.MessageViews.ForEachAsync(mv =>
                                {
                                    if (mv.MessageId == item.MessageId)
                                    {
                                        tempusvm.WhoViewed.Add(mv.UserId);
                                    }
                                });
                                messages.Add(tempusvm);
                                foreach (ReplyMessage replym in _context.ReplyMessages.Where(rm => rm.MessageId == tempm.Id))
                                {
                                    replyMessages.Add(replym);
                                }
                            }
                            foreach (UserChat userChat in _context.UserChats.Where(uc => uc.ChatId == chat.Id))
                            {
                                tempu = await _context.Users.FirstAsync(u => u.Id == userChat.UserId);
                                members.Add(_mapper.Map<UserViewModel>(tempu));
                            }
                            ChatViewModel cvm = _mapper.Map<ChatViewModel>(chat);
                            cvm.Members = await GetChatMembers(cvm.Id);
                            await _context.SaveChangesAsync();
                            return Ok(new { chat = cvm, messages, members, replyMessages });
                        }
                        else return BadRequest(new { error = "Private chat not found(wtf)." });
                    }
                    else return NotFound(new { error = "private chat not found." });
                }
                return BadRequest(new { error = "Invalid request." });
            }
            else return BadRequest(new { error = "Invalid request." });

        }
        [Authorize]
        [HttpPost("leavepublicchat")]
        public async Task<ActionResult> LeavePublicChat([FromBody] EnterPublicChat chat)
        {
            if (chat != null)
            {
                if (chat.ChatName != null)
                {
                    Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.ChatName == chat.ChatName);
                    User? u = await _context.Users.FirstOrDefaultAsync(us => us.UserName == chat.UserName);
                    if (u != null && c != null)
                    {
                        UserChat? uc = await _context.UserChats.FirstOrDefaultAsync(uch => uch.UserId == u.Id && uch.ChatId == c.Id);
                        if (uc != null)
                        {
                            _context.UserChats.Remove(uc);
                            c.MembersCount--;
                            if (c.Type == "Group")
                            {
                                Message sysmsg = new()
                                {
                                    UserId = 745,
                                    SendTime = DateTime.Now,
                                    DeliveryStatus = true,
                                    Text = $"{u.UserName} has left the {c.ChatName}"
                                };
                                await _context.Messages.AddAsync(sysmsg);
                                await _context.SaveChangesAsync();
                                sysmsg = await _context.Messages.FirstAsync(msg => msg.UserId == 745 && msg.Text == $"{u.UserName} has left the {c.ChatName}");
                                ChatMessage syscmsg = new ()
                                {
                                    ChatId = c.Id,
                                    MessageId = sysmsg.Id
                                };
                                await _context.ChatMessages.AddAsync(syscmsg);
                            }
                            _context.Entry(c).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            UpdateLastOnline(u);
                            return Ok(new { result = "success" });
                        }
                        else return BadRequest(new { error = "User is not in this chat..." });
                    }

                    else return NotFound(new { error = "user or chat not found" });
                }
            }
            return BadRequest(new { error = "Request was null" });
        }
        [Authorize]
        [HttpPost("enterprivatechat")]
        public async Task<ActionResult> EnterPrivateChat([FromBody] EnterPrivateChat chat)
        {
            Chat? temp;
            int counter = 0;
            if (chat != null)
            {
                if (chat.OpponentName != null && chat.UserName!=null)
                {
                    User? op = await _context.Users.FirstOrDefaultAsync(us => us.UserName == chat.OpponentName);
                    User? u = await _context.Users.FirstOrDefaultAsync(us => us.UserName == chat.UserName);
                    if (u != null && op != null)
                    {
                        List<Chat> userChats = new();
                        foreach (UserChat item in _context.UserChats)
                        {
                            if (item.UserId == u.Id)
                            {
                                temp = await _context.Chats.FirstOrDefaultAsync(c => c.Id == item.ChatId);
                                if (temp!=null && temp.Type == "Private")
                                {
                                    userChats.Add(temp);
                                }
                            }
                        }
                        foreach (Chat item in userChats)
                        {
                            if(await _context.UserChats.AnyAsync(uch => uch.UserId == op.Id && uch.ChatId == item.Id))
                            {
                                counter++;
                            }
                        }
                        if (counter == 0)
                        {
                            Chat newPrivate = new()
                            {
                                ShortMessage = $"Chat between {u.UserName} and {op.UserName}",
                                Type = "Private",
                                AuthorId = u.Id,
                                ChatImage = null,
                                PinnedMessageId = null,
                                MembersCount = 2,
                            };
                            await _context.Chats.AddAsync(newPrivate);
                            await _context.SaveChangesAsync();
                            Chat? newChat = await _context.Chats.FirstOrDefaultAsync(nc => nc.ShortMessage == $"Chat between {u.UserName} and {op.UserName}");
                            if (newChat != null)
                            {
                                UserChat newUserChatPrivate = new()
                                {
                                    UserId = u.Id,
                                    ChatId = newChat.Id
                                };
                                UserChat newOpponentChatPrivate = new()
                                {
                                    UserId = op.Id,
                                    ChatId = newChat.Id
                                };
                                await _context.UserChats.AddAsync(newUserChatPrivate);
                                await _context.UserChats.AddAsync(newOpponentChatPrivate);
                                await _context.SaveChangesAsync();
                                ChatViewModel cvm = _mapper.Map<ChatViewModel>(newChat);
                                UpdateLastOnline(u);
                                return Ok(new {result="success",newChat=cvm});
                            }
                            else return BadRequest(new { error = "unknown chat creation error...." });
                        }
                        else return BadRequest(new { error = "User already in private chat with this opponent..." });
                    }

                    else return NotFound(new { error = "user or opponent not found" });
                }
            }
            return BadRequest(new { error = "Request was null" });
        }
        [Authorize]
        [HttpPost("createchat")]
        public async Task<ActionResult> CreateChat([FromBody] CreatePublicChat chat)
        {
            if (chat != null)
            {
                List<string> errors = new();
                User? u = await _context.Users.FirstOrDefaultAsync(us => us.Id == chat.AuthorId);
                if (u != null)
                {
                    if (chat.ChatImage != null)
                    {
                        Match match = DataUriPattern.Match(chat.ChatImage);
                        if (match.Success)
                        {
                            Chat newChat = new()
                            {
                                ChatInfo = chat.ChatInfo,
                                AuthorId = chat.AuthorId,
                                ChatName = chat.ChatName,
                                ShortMessage = "empty...",
                                ChatImage = chat.ChatImage,
                                PublishTime = DateTime.Now,
                                MembersCount = 1,
                                Type = chat.Type,
                                PinnedMessageId = null
                            };
                            try
                            {
                                await _context.Chats.AddAsync(newChat);
                                await _context.SaveChangesAsync();
                                newChat = await _context.Chats.FirstAsync(c => c.ChatName == chat.ChatName && c.AuthorId == chat.AuthorId);
                                UserChat uc = new()
                                {
                                    ChatId = newChat.Id,
                                    UserId = u.Id,
                                };
                                await _context.UserChats.AddAsync(uc);
                                await _context.SaveChangesAsync();
                                if (chat.Members != null && chat.Members.Count > 0)
                                {
                                    User? tempu;
                                    UserChat? tempuc;
                                    int counter = 0;
                                    bool validcounter = true;
                                    foreach (int item in chat.Members)
                                    {
                                        tempu = await _context.Users.FirstOrDefaultAsync(u => u.Id == item);
                                        if (tempu != null)
                                        {
                                            foreach (UserChat userChat in _context.UserChats.Where(u => u.ChatId == newChat.Id))
                                            {
                                                if (userChat.UserId == tempu.Id)
                                                {
                                                    errors.Add($"User with id: {tempu.Id} is already in this chat.");
                                                    validcounter = false;
                                                }
                                            }
                                            if (validcounter)
                                            {
                                                tempuc = new UserChat
                                                {
                                                    ChatId = newChat.Id,
                                                    UserId = tempu.Id,
                                                };
                                                await _context.UserChats.AddAsync(tempuc);
                                                counter++;
                                                await _context.SaveChangesAsync();
                                            }
                                        }
                                    }
                                    newChat.MembersCount += counter;
                                }
                                _context.Chats.Entry(newChat).State = EntityState.Modified;
                                await _context.SaveChangesAsync();
                                ChatViewModel cvm = _mapper.Map<ChatViewModel>(newChat);
                                return Ok(new { result = "success", chat = cvm, userchat = uc });
                            }
                            catch (Exception ex)
                            {
                                return BadRequest(new { error = ex.Message });
                            }
                        }
                        else return BadRequest(new { error = "Invalid base64 image string." });
                    }
                    else
                    {
                        Chat newChat = new()
                        {
                            ChatInfo = chat.ChatInfo,
                            AuthorId = chat.AuthorId,
                            ChatName = chat.ChatName,
                            ShortMessage = "empty...",
                            ChatImage = null,
                            PublishTime = DateTime.Now,
                            MembersCount = 1,
                            Type = chat.Type,
                            PinnedMessageId = null
                        };

                        try
                        {
                            await _context.Chats.AddAsync(newChat);
                            await _context.SaveChangesAsync();
                            newChat = await _context.Chats.FirstAsync(c => c.ChatName == chat.ChatName && c.AuthorId == chat.AuthorId);
                            UserChat uc = new()
                            {
                                ChatId = newChat.Id,
                                UserId = u.Id,
                            };
                            await _context.UserChats.AddAsync(uc);
                            await _context.SaveChangesAsync();
                            UpdateLastOnline(u); 
                            if (chat.Members != null && chat.Members.Count > 0)
                            {
                                User? tempu;
                                UserChat? tempuc;
                                int counter = 0;
                                bool validcounter = true;
                                foreach (int item in chat.Members)
                                {
                                    tempu = await _context.Users.FirstOrDefaultAsync(u => u.Id == item);
                                    if (tempu != null)
                                    {
                                        foreach (UserChat userChat in _context.UserChats.Where(u => u.ChatId == newChat.Id))
                                        {
                                            if (userChat.UserId == tempu.Id)
                                            {
                                                errors.Add($"User with id: {tempu.Id} is already in this chat.");
                                                validcounter = false;
                                            }
                                        }
                                        if (validcounter)
                                        {
                                            tempuc = new UserChat
                                            {
                                                ChatId = newChat.Id,
                                                UserId = tempu.Id,
                                            };
                                            await _context.UserChats.AddAsync(tempuc);
                                            counter++;
                                            await _context.SaveChangesAsync();
                                        }
                                    }
                                }
                                newChat.MembersCount += counter;
                            }
                            _context.Chats.Entry(newChat).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            ChatViewModel cvm = _mapper.Map<ChatViewModel>(newChat);
                            return Ok(new { result = "success", chat = cvm, userchat = uc });
                        }
                        catch (Exception ex)
                        {
                            return BadRequest(new { error = ex.Message });
                        }
                    }
                }
                return BadRequest(new { error = "Author not found." });

            }
            return BadRequest(new { error = "Request was null" });
        }
        [Authorize]
        [HttpPost("editpublicchat")]
        public async Task<ActionResult> EditChat([FromBody] EditPublicChat chat)
        {
            Chat? c = await _context.Chats.FirstOrDefaultAsync(ch=>ch.Id == chat.Id);
            List<string> errors = new();
            if (c == null) return NotFound(new { error = "Chat not found." });
            if (chat.ChatName != null)
            {
                c.ChatName = chat.ChatName;
            }
            if(chat.ChatImage != null)
            {
                Match m = DataUriPattern.Match(chat.ChatImage);
                if (m.Success) c.ChatImage = chat.ChatImage;
                else errors.Add("Invalid base64 image string");
            }
            if (chat.ChatInfo != null)
            {
                c.ChatInfo = chat.ChatInfo;
            }
            if(chat.Members != null && chat.Members.Count>0)
            {
                User? tempu;
                UserChat? tempuc;
                int counter = 0;
                bool validcounter = true;
                foreach (int item in chat.Members)
                {
                    tempu = await _context.Users.FirstOrDefaultAsync(u => u.Id == item);
                    if (tempu != null)
                    {
                        foreach (UserChat userChat in _context.UserChats.Where(u=>u.ChatId==chat.Id))
                        {
                            if (userChat.UserId == tempu.Id)
                            {
                                errors.Add($"User with id: {tempu.Id} is already in this chat.");
                                validcounter = false;
                            }
                        }
                        if (validcounter)
                        {
                            tempuc = new UserChat
                            {
                                ChatId = chat.Id,
                                UserId = tempu.Id,
                            };
                            await _context.UserChats.AddAsync(tempuc);
                            counter++;
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                c.MembersCount += counter;
            }
            try
            {
                _context.Chats.Entry(c).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(new {result="success",errors});
            }
            catch (Exception ex)
            {
                return BadRequest(new {error="Chat saving error.",exception= ex.Message, });
            }
        }
        [Authorize]
        [HttpDelete("deletechatmember")]
        public async Task<ActionResult> DeleteChatMember([FromBody] DeleteChatMember chat)
        {
            if (chat != null)
            {
                Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == chat.Id);
                if (c != null)
                {
                    if (chat.Members != null && chat.Members.Count > 0)
                    {
                        User? tempu;
                        UserChat? tempuc;
                        int counter = 0;
                        foreach (int item in chat.Members)
                        {
                            tempu = await _context.Users.FirstOrDefaultAsync(u => u.Id == item);
                            if (tempu != null)
                            {
                                tempuc = await _context.UserChats.FirstOrDefaultAsync(u => u.UserId == tempu.Id && u.ChatId == c.Id);
                                if (tempuc != null)
                                {
                                    _context.UserChats.Remove(tempuc);
                                    counter++;
                                }
                                await _context.SaveChangesAsync();
                            }
                        }
                        c.MembersCount -= counter;
                    }
                    else return BadRequest(new { error = "Invalid list of members."});
                    try
                    {
                        _context.Chats.Entry(c).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(new { error = "Chat saving error.", exception = ex.Message, });
                    }
                }
                else return NotFound(new { error = "Chat not found." });
            }
            return BadRequest(new { error = "Request was null" });
        }
        [Authorize]
        [HttpPost("findchats")]
        public async Task<ActionResult> FindChats([FromBody] ChatTitle chatName)
        {
            if (chatName != null)
            {
                if (chatName.Text!=null && chatName.Text.Length < 3)
                {
                    return BadRequest(new { error = "Query must be at least 3 symbols." });
                }
                else
                {
                    List<ChatViewModel>? chats = new();
                    List<UserViewModel>? users = new();
                    try
                    { 
                        await _context.Users.ForEachAsync(u =>
                        {
                            if (u.UserName.ToLower().Contains(chatName.Text.ToLower()))
                            {
                                users.Add(_mapper.Map<UserViewModel>(u));
                            }
                        });
                    }
                    catch
                    {

                        return BadRequest(new { error = "error in username" });
                    }
                    try
                    {
                        foreach (Chat chat in _context.Chats)
                        {
                            if (chat.Type != "Private" && chat.Type != "Favorite")
                            {
                                if (chat.ChatName != null)
                                {
                                    if (chat.ChatName.ToLower().Contains(chatName.Text.ToLower()))
                                    {
                                        chats.Add(_mapper.Map<ChatViewModel>(chat));
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {

                        return BadRequest(new { error = "error in chat" });
                    }

                    return Ok(new { users, chats });
                }
            }
            return BadRequest(new { error = "Request was null." });
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChat(int id)
        {
            Chat? chat = await _context.Chats.FirstOrDefaultAsync(c => c.Id == id);
            if (chat == null) return NotFound(new {error="Chat not found."}); 
            else
            {
                Message tempm;
                try
                {
                    foreach (ChatMessage item in _context.ChatMessages.Where(cm => cm.ChatId == chat.Id))
                    {
                        tempm = await _context.Messages.FirstAsync(m => m.Id == item.MessageId);
                        _context.Messages.Remove(tempm);
                        _context.ChatMessages.Remove(item);
                    }
                    foreach (UserChat userChat in _context.UserChats.Where(uc => uc.ChatId == chat.Id))
                    {
                        _context.UserChats.Remove(userChat);
                    }
                    _context.Chats.Remove(chat);
                    await _context.SaveChangesAsync();
                    return Ok(new {Result="Success"});
                }
                catch (Exception ex)
                {
                    return BadRequest(new {error = "Deleting error.", exception=ex.Message});
                }
                
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChatById(int id)
        {
            Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == id);
            if (c == null) return NotFound(new { error = "Chat not found." });
            List<UserViewModel> members = new();
            User? u;
            foreach (UserChat userChat in _context.UserChats.Where(uc => uc.ChatId == c.Id))
            {
                u = await _context.Users.FirstAsync(u => u.Id == userChat.UserId);
                members.Add(_mapper.Map<UserViewModel>(u));
            }
            ChatViewModel cvm = _mapper.Map<ChatViewModel>(c);
            cvm.Members = await GetChatMembers(cvm.Id);
            return Ok(new { chat = cvm });
        }
        [Authorize]
        [HttpPost("mutechat")]
        public async Task<IActionResult> ChangeNotificationStatus([FromBody] MuteChat mc)
        {
            Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == mc.ChatId);
            User? u = await _context.Users.FirstOrDefaultAsync(u=>u.Id == mc.UserId);
            if (c == null) return NotFound(new {error="Chat not found"});
            if (u == null) return NotFound(new { error = "User not found" });
            if (!_context.UserChats.Contains(new UserChat { UserId = u.Id, ChatId = c.Id })) return BadRequest(new { error = "User isnt in this chat" });
            if (!_context.ChatMutes.Contains(new ChatMute { ChatId=c.Id, UserId = u.Id}))
            {
                ChatMute cm = new ChatMute { UserId = u.Id, ChatId=c.Id };
                await _context.ChatMutes.AddAsync(cm);
                await _context.SaveChangesAsync();
                return Ok(new { result = $"chat muted by {u.UserName}" });
            }
            else
            {
                ChatMute cm = await _context.ChatMutes.FirstAsync(cmute=>cmute.ChatId==c.Id && cmute.UserId == u.Id);
                _context.ChatMutes.Remove(cm);
                await _context.SaveChangesAsync();
                return Ok(new { result = $"chat unmuted by {u.UserName}" });
            }
        }
        [Authorize]
        [HttpPost("isuserinchat")]
        public async Task<IActionResult> UserInChat([FromBody] UserInChat uic)
        {
            bool result = false;
            if (await _context.UserChats.ContainsAsync(new UserChat { ChatId = uic.ChatId, UserId = uic.UserId })) result = true;
            return Ok(new { result });
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
