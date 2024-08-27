using ContactWebApp.Data;
using ContactWebApp.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        public ContactDBContext _context = new ContactDBContext();
        // GET: api/<ContactDetailsController>
        [HttpGet]
        public IEnumerable<ContactDetail> Get()
        {
            return _context.ContactDetails.ToList();
        }

        // GET api/<ContactDetailsController>/5
        [HttpGet("{id}")]
        public ContactDetail Get(int id)
        {
            return _context.ContactDetails.Find(id);
        }

        // POST api/<ContactDetailsController>
        [HttpPost]
        public void Post([FromBody] ContactDetail newContactDetail)
        {
            _context.ContactDetails.Add(newContactDetail);
            _context.SaveChanges();
        }

        // PUT api/<ContactDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
