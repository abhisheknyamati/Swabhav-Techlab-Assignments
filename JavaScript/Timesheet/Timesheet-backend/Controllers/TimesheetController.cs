using Microsoft.AspNetCore.Mvc;
using timesheet.Data;
using timesheet.Model;
using System.Collections.Generic;
using System.Linq;

namespace timesheet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {
        private readonly TimesheetDBContext _context;

        public TimesheetController(TimesheetDBContext context)
        {
            _context = context;
        }

        // GET: api/<TimesheetController>
        [HttpGet]
        public IEnumerable<Timesheet> Get()
        {
            return _context.Timesheets.ToList();
        }

        // POST api/<TimesheetController>
        [HttpPost]
        public IActionResult Post([FromBody] Timesheet value)
        {
            if (value == null)
            {
                return BadRequest("Timesheet object is null");
            }

            _context.Timesheets.Add(value);
            _context.SaveChanges();

            return Ok(value);
        }

        // GET api/<TimesheetController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var timesheet = _context.Timesheets.FirstOrDefault(t => t.Id == id);
            if (timesheet == null)
            {
                return NotFound();
            }
            return Ok(timesheet);
        }
    }
}
