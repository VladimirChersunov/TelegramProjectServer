using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server;
using server.DTO.Message;
using server.Migrations;
using server.Models;
using server.ViewModels;

namespace server.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly Regex DataUriPattern = new(@"^data\:(?<type>image\/(png|tiff|jpg|gif|jpeg));base64,(?<data>[A-Z0-9\+\/\=]+)$", RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
        private readonly IMapper _mapper;

        public MessagesController(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("chat/{id}")]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessagesFromChatId(int id)
        {
            List<Message> messages = new();
            Message? temp;
            Chat? chat = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == id);
            if(chat != null)
            {
                foreach (ChatMessage item in _context.ChatMessages)
                {
                    if(item.ChatId == chat.Id)
                    {
                        temp = await _context.Messages.FirstOrDefaultAsync(m => m.Id == item.MessageId);
                        if(temp!=null) messages.Add(temp);
                    }
                }
                return Ok(new {messages});
            }
            return NotFound(new {error="Chat with this title does not exists"});
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<MessageViewModel>> GetMessage(int id)
        {
            var message = await _context.Messages.FindAsync(id);

            if (message == null)
            {
                return NotFound();
            }

            return _mapper.Map<MessageViewModel>(message);
        }


        [Authorize]
        [HttpPost("sendmessage")]
        public async Task<ActionResult> SendMessage([FromBody] SendMessage sm)
        {
            User? u = await _context.Users.FirstOrDefaultAsync(us => us.Id == sm.UserId);
            Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == sm.ChatId);
            if (u != null)
            {
                if(c != null)
                {
                    if (sm.Data != null)
                    {
                        Match match = DataUriPattern.Match(sm.Data);
                        if (match.Success)
                        {
                            Message newMsg = new()
                            {
                                DeliveryStatus = true,
                                SendTime = DateTime.Now,
                                Data = sm.Data,
                                Text = sm.Text,
                                UserId = sm.UserId
                            };
                            try
                            {
                                await _context.Messages.AddAsync(newMsg);
                                await _context.SaveChangesAsync();
                                Chat? tempc = await _context.Chats.FirstAsync(c => c.Id == sm.ChatId);
                                User? tempUser = await _context.Users.FirstAsync(u => u.Id == sm.UserId);
                                tempc.ShortMessage = $"{tempUser.UserName}:{newMsg.Text}";
                                tempc.PublishTime = DateTime.Now;
                                ChatMessage newCMsg = new()
                                {
                                    ChatId = sm.ChatId,
                                    MessageId = _context.Messages.First(m => m.Text == newMsg.Text && m.SendTime == newMsg.SendTime).Id
                                };
                                _context.Entry(tempc).State = EntityState.Modified;
                                await _context.ChatMessages.AddAsync(newCMsg);
                                await _context.SaveChangesAsync();
                            }
                            catch (Exception ex)
                            {
                                return BadRequest(new { result = "DatabaseCreatingMessageError", error = ex.Message, DeliveryStatus = false });
                            }
                            UpdateLastOnline(u);
                            return Ok(new { DeliveryStatus = true });
                        }
                        else return BadRequest(new { error = "Invalid base64 image string.", DeliveryStatus = false });
                    }
                    else
                    {
                        Message newMsg = new()
                        {
                            DeliveryStatus = true,
                            SendTime = DateTime.Now,
                            Data = null,
                            Text = sm.Text,
                            UserId = sm.UserId
                        };
                        try
                        {
                            await _context.Messages.AddAsync(newMsg);
                            await _context.SaveChangesAsync();
                            Chat? tempc = await _context.Chats.FirstAsync(c => c.Id == sm.ChatId);
                            User? tempUser = await _context.Users.FirstAsync(u => u.Id == sm.UserId);
                            tempc.ShortMessage = $"{tempUser.UserName}:{newMsg.Text}";
                            tempc.PublishTime = DateTime.Now;
                            ChatMessage newCMsg = new()
                            {
                                ChatId = sm.ChatId,
                                MessageId = _context.Messages.First(m => m.Text == newMsg.Text && m.SendTime == newMsg.SendTime).Id
                            };
                            _context.Entry(tempc).State = EntityState.Modified;
                            await _context.ChatMessages.AddAsync(newCMsg);
                            await _context.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            return BadRequest(new { result = "DatabaseCreatingMessageError", error = ex.Message, DeliveryStatus = false });
                        }

                        UpdateLastOnline(u);
                        return Ok(new { DeliveryStatus = true });
                    }
                }
                else return BadRequest(new { error = "Chat not found.", DeliveryStatus = false });
            }
            else return BadRequest(new {error="User not found.", DeliveryStatus = false });
        }

        [Authorize]
        [HttpPost("forwardmessage")]
        public async Task<ActionResult> ForwardMessage([FromBody] ForwardMessage fm)
        {
            User? u = await _context.Users.FirstOrDefaultAsync(us => us.Id == fm.UserId);
            User? s = await _context.Users.FirstOrDefaultAsync(us => us.Id == fm.SenderId);
            Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == fm.ChatId);
            Message? sm = await _context.Messages.FirstOrDefaultAsync(ms => ms.Id == fm.MessageId);
            if (u != null)
            {
                if (s != null)
                {
                    if (c != null)
                    {
                        if (sm != null)
                        {
                            UserChat? uc = await _context.UserChats.FirstOrDefaultAsync(uchat => uchat.UserId == u.Id && uchat.ChatId == c.Id);
                            Message newMsg = new()
                            {
                                DeliveryStatus = true,
                                SendTime = DateTime.Now,
                                Data = sm.Data,
                                Text = sm.Text,
                                UserId = fm.SenderId
                            };
                            try
                            {
                                await _context.Messages.AddAsync(newMsg);
                                await _context.SaveChangesAsync();
                                ChatMessage newCMsg = new()
                                {
                                    ChatId = fm.ChatId,
                                    MessageId = _context.Messages.First(m => m.Text == newMsg.Text && m.SendTime == newMsg.SendTime).Id
                                }; 
                                Chat? tempc = await _context.Chats.FirstAsync(c => c.Id == fm.ChatId);
                                User? tempUser = await _context.Users.FirstAsync(u => u.Id == fm.SenderId);
                                tempc.ShortMessage = $"{tempUser.UserName}:{newMsg.Text}";
                                tempc.PublishTime = DateTime.Now;
                                _context.Entry(tempc).State = EntityState.Modified;
                                await _context.ChatMessages.AddAsync(newCMsg);
                                await _context.SaveChangesAsync();
                            }
                            catch (Exception ex)
                            {
                                return BadRequest(new { result = "DatabaseCreatingMessageError", error = ex.Message });
                            }
                            UpdateLastOnline(u);
                            return Ok(new { DeliveryStatus = true });
                        }
                        else return BadRequest(new {error="Message not found.", DeliveryStatus = false });
                        
                    }
                    else return BadRequest(new { error = "Chat not found.", DeliveryStatus = false });
                }
                else return BadRequest(new { error = "Sender not found.", DeliveryStatus = false });
               
            }
            else return BadRequest(new { error = "User not found.", DeliveryStatus = false });
        }
        [Authorize]
        [HttpDelete("deletemessage")]
        public async Task<IActionResult> DeleteMessage([FromBody] DeleteMessage dm)
        {
            Message? m = await _context.Messages.FirstOrDefaultAsync(msg => msg.Id == dm.MessageId);
            User? u = await _context.Users.FirstOrDefaultAsync(us => us.Id == dm.UserId);
            if (m == null) return BadRequest(new { error = "Message not found." });
            if (u == null) return BadRequest(new { error = "User not found." });
            ChatMessage? cm = await _context.ChatMessages.FirstOrDefaultAsync(c => c.MessageId == m.Id);
            if (cm == null) return BadRequest(new { error = "Chat with this message not found." });
            try
            {
                _context.Remove(m);
                _context.Remove(cm);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(new { result = "Error deleting message.", error = ex.Message });
            }
            return Ok(new { result = "success" });
        }
        [Authorize]
        [HttpPost("readmessages")]
        public async Task<IActionResult> ReadChat([FromBody] MessageViewed mv)
        {
            Chat? c = await _context.Chats.FirstOrDefaultAsync(ch => ch.Id == mv.ChatId);
            if (c == null) return NotFound(new { error = "Chat not found" });
            Message tempm;
            List<MessageView> mviews = new();
            MessageView messageViewed;
            foreach (ChatMessage item in _context.ChatMessages.Where(cm => cm.ChatId == mv.ChatId))
            {
                tempm = await _context.Messages.FirstAsync(m => m.Id == item.MessageId);
                if (!await _context.MessageViews.ContainsAsync(new MessageView { MessageId = tempm.Id, UserId = mv.UserId}))
                {
                    messageViewed = new MessageView
                    {
                        UserId = mv.UserId,
                        MessageId = tempm.Id
                    };
                    mviews.Add(messageViewed);
                }
            }
            HashSet<MessageView> messageViews = mviews.ToHashSet();
            if (messageViews.Count > 0)
            {
                try
                {
                    await _context.MessageViews.AddRangeAsync(messageViews);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        return BadRequest(new { error = "saving changes error", ex.InnerException.Message, messageViews });
                    else return BadRequest(new { error = "saving changes error", ex, messageViews });
                }
            }

            return Ok(new { result = "Chat readed." });
        }
        [Authorize]
        [HttpGet("whoreaded/{id}")]
        public async Task<IActionResult> WhoReadedMessage(int id)
        {
            Message? temp = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
            List<UserViewModel> viewedUsers = new();
            User? tempu;
            if (temp == null) return NotFound(new { error = "Message not found" });
            foreach (MessageView item in _context.MessageViews.Where(mv=>mv.MessageId==temp.Id))
            {
                tempu = await _context.Users.FirstAsync(u => u.Id == item.UserId);
                viewedUsers.Add(_mapper.Map<UserViewModel>(tempu));
            }
            return Ok(viewedUsers);
        }

        [Authorize]
        [HttpPost("replymessage")]
        public async Task<IActionResult> MessageReply ([FromBody] ReplyToMessage rm)
        {
            if(rm == null) return BadRequest(new {error="Request was null."});
            Message? replying = await _context.Messages.FirstOrDefaultAsync(m => m.Id == rm.ReplyingMessageId);
            User? tempu = await _context.Users.FirstOrDefaultAsync(u => u.Id == rm.UserId);
            if (replying == null) return BadRequest(new { error = "Replying message not found." });
            if (tempu == null) return BadRequest(new { error = "User not found." });
            string? tempData = null;
            if (rm.Data != null) tempData = rm.Data;
            Message reply = new()
            {
                Text = rm.Text,
                DeliveryStatus = true,
                UserId = rm.UserId,
                SendTime = DateTime.Now,
                Data = tempData
            };
            try
            {
                await _context.Messages.AddAsync(reply);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Db saving message error", ex = ex.Message });
            }
            reply = await _context.Messages.FirstAsync(m => m.UserId == rm.UserId && m.Text == rm.Text);

            ReplyMessage replym = new()
            {
                MessageId = reply.Id,
                ReplyId = rm.ReplyingMessageId
            };
            ChatMessage tempcm = await _context.ChatMessages.FirstAsync(cm => cm.MessageId == rm.ReplyingMessageId);
            ChatMessage replycm = new()
            {
                MessageId = reply.Id,
                ChatId = tempcm.ChatId
            };
            try
            {
                await _context.ReplyMessages.AddAsync(replym);
                await _context.ChatMessages.AddAsync(replycm);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Db saving replyMessage error", ex=ex.Message });
            }
            return Ok(new {result="Reply added.", replym, reply});
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
    }
}
