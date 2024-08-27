using ContactWebApp.Data;
using ContactWebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public ContactDBContext _context = new ContactDBContext();
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return _context.Contacts.Include(c => c.ContactDetails).ToList();
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _context.Contacts.Include(c => c.ContactDetails).FirstOrDefault(c => c.Id == id);
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] Contact newContact)
        {
            _context.Contacts.Add(newContact);
            _context.SaveChanges();
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
