using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server;
using server.DTO.UserContact;
using server.Models;
using server.ViewModels;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserContactsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public UserContactsController(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("user/{username}")]
        public async Task<ActionResult<IEnumerable<UserContact>>> GetContactsForCurrentUser(string username)
        {
            User? u = await _context.Users.FirstOrDefaultAsync(us => us.UserName == username);
            if (u != null)
            {
                List<UserViewModel> contacts = new();
                foreach (UserContact item in _context.UserContacts)
                {
                    if (item.UserId == u.Id)
                    {
                        contacts.Add(_mapper.Map<UserViewModel>(await _context.Users.FirstOrDefaultAsync(us=>us.Id==item.ContactId)));
                    }
                }
                return Ok(new { contacts });
            }
            else return BadRequest(new { error = "User not found..." });
        }

        [Authorize]
        [HttpPost("createcontact")]
        public async Task<ActionResult<UserContact>> CreateContact([FromBody] ContactUpdate contactUpdate)
        {
            if (contactUpdate != null)
            {
                User u = await _context.Users.FirstAsync(us => us.UserName == contactUpdate.CurrentUserLogin);
                User? contact = await _context.Users.FirstOrDefaultAsync(us => us.UserName == contactUpdate.ContactUserName);
                if (contact != null)
                {
                    if (!await _context.UserContacts.AnyAsync(ucon => ucon.UserId == u.Id && ucon.ContactId == contact.Id))
                    {
                        UserContact uc = new UserContact
                        {
                            UserId = u.Id,
                            ContactId = contact.Id,
                            NotificationStatus = true
                        };
                        _context.UserContacts.Add(uc);
                        await _context.SaveChangesAsync();
                        UpdateLastOnline(u);
                        return Ok(new { result = "Success", uc });
                    }
                    else return BadRequest(new { error = "Contact already exists.." });

                }
                else return NotFound(new { error = "Contact not found..." });
            }
            else return BadRequest(new { error = "Request model was null" });
        }
        [Authorize]
        [HttpDelete("deletecontact")]
        public async Task<ActionResult<UserContact>> DeleteContact([FromBody] ContactUpdate contactUpdate)
        {
            if (contactUpdate != null)
            {
                User u = await _context.Users.FirstAsync(us => us.UserName == contactUpdate.CurrentUserLogin);
                User? contact = await _context.Users.FirstOrDefaultAsync(us => us.UserName == contactUpdate.ContactUserName);
                if (contact != null && u != null)
                {
                    if (await _context.UserContacts.AnyAsync(ucon => ucon.UserId == u.Id && ucon.ContactId == contact.Id))
                    {
                        UserContact uc = _context.UserContacts.First(ucon => ucon.UserId == u.Id && ucon.ContactId == contact.Id);
                        _context.UserContacts.Remove(uc);
                        await _context.SaveChangesAsync();
                        UpdateLastOnline(u);
                        return Ok(new { result = "Success" });
                    }
                    else return BadRequest(new { error = "UserContact not found.." });

                }
                else return NotFound(new { error = "Contact not found..." });
            }
            else return BadRequest(new { error = "Request model was null" });
        }

        private bool UserContactExists(int id)
        {
            return _context.UserContacts.Any(e => e.Id == id);
        }
        [Authorize]
        [HttpPost("iscontact")]
        public async Task<IActionResult> IsInContacts([FromBody] IsContact uic)
        {
            bool result = false;
            if (await _context.UserContacts.AnyAsync(uc=>uc.ContactId == uic.ContactId && uc.UserId == uic.UserId )) result = true;
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
    }
}
