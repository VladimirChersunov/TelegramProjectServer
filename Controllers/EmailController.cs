using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.DTO.Email;
using server.Helpers;
using server.Helpers.Email;
using server.Models;
using System.Linq;

namespace server.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IMailService _mailService;
        public EmailController(ApplicationContext context, IMailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }


        [HttpPost("sendcode")]
        public async Task<ActionResult> SendEmail([FromBody]emailModel email)
        {
            Random random = new Random();
            string code = string.Empty;
            for (int i = 0; i <= 4; i++)
            {
                code = code.Insert(code.Length, random.Next(0, 10).ToString());
            }
            try
            {
                await _mailService.SendEmailAsync(new MailRequest { Body = "Your verification code: " + code, Subject = "Confirmation code", ToEmail = email.Email });
                return Ok(new { code, email=email.Email });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("unique")]
        public async Task<ActionResult> IsUnique([FromBody] uniqueCheckModel uniqueModel)
        {
            bool unique = true;
            if (await _context.Users.AnyAsync(u=>u.UserName== uniqueModel.UserName || u.Email == uniqueModel.Email))
            {
                unique = false;
            }
            return Ok(new { unique });
        }

        [HttpPost("validatetoken")]
        public async Task<ActionResult> ValidateToken([FromBody] validateTokenModel tokenModel)
        {
            bool valid = false;
            valid = await TokenGen.ValidateCurrentToken(tokenModel.Token);
           return Ok(new { valid });
            
        }
    }
}
