using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server;
using server.DTO.BugReport;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugReportsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public BugReportsController(ApplicationContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BugReport>>> GetBugReports()
        {
          if (_context.BugReports == null)
          {
              return NotFound();
          }
            return await _context.BugReports.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<BugReport>> GetBugReport(int id)
        {
          if (_context.BugReports == null)
          {
              return NotFound();
          }
            var bugReport = await _context.BugReports.FindAsync(id);

            if (bugReport == null)
            {
                return NotFound();
            }

            return bugReport;
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBugReport(int id, BugReport bugReport)
        {
            if (id != bugReport.Id)
            {
                return BadRequest();
            }

            _context.Entry(bugReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BugReportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<BugReport>> PostBugReport([FromBody]BugReportDTO bugReport)
        {
          if (_context.BugReports == null)
          {
              return Problem("Entity set 'ApplicationContext.BugReports'  is null.");
          }
            BugReport bug = new BugReport
            {
                UserName = bugReport.UserName,
                BugDescription = bugReport.BugDescription,
                BugTitle = bugReport.BugTitle,
                Date = DateTime.UtcNow
            };
            _context.BugReports.Add(bug);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBugReport", new { id = bug.Id },bug);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBugReport(int id)
        {
            if (_context.BugReports == null)
            {
                return NotFound();
            }
            var bugReport = await _context.BugReports.FindAsync(id);
            if (bugReport == null)
            {
                return NotFound();
            }

            _context.BugReports.Remove(bugReport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BugReportExists(int id)
        {
            return (_context.BugReports?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
