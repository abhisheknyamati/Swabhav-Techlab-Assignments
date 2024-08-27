using ContactWebApp.Data;
using ContactWebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public ContactDBContext _context = new ContactDBContext();
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.Include(u => u.Contacts).ThenInclude(c => c.ContactDetails).ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _context.Users.Include(u => u.Contacts).ThenInclude(c => c.ContactDetails).FirstOrDefault(u => u.Id == id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.Include(u => u.Contacts).FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            user.IsAdmin = updatedUser.IsAdmin;
            user.IsActive = updatedUser.IsActive;
            user.Contacts = updatedUser.Contacts;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Users.Remove(_context.Users.FirstOrDefault(u => u.Id == id));
            _context.SaveChanges();
        }
    }
}
