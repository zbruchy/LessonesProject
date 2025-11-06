using SchoolDigital.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SchoolDigital.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolDigital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var user = _userService.GetById(id);
            if (user != null)
                return Ok(user);
            return NotFound();
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User value)
        {
            /*var u = _context.users.Find(x => x.Id == value.Id);
            if (u != null)
            {
                return Conflict();
            }
            _context.users.Add(value);*/
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User value)
        {
            /*var index = _context.users.FindIndex(u => u.Id == id);
            if (index >= 0)
            {
                _context.users[index].Name = value.Name;
                _context.users[index].Role = value.Role;
                _context.users[index].Email = value.Email;
                return Ok();
            }*/
            return NotFound();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            /*var user = _context.users.FirstOrDefault((u) => u.Id == id);
            if (user != null)
            {
                _context.users.Remove(user);
                return Ok();
            } */               
            return BadRequest();
        }
    }
}
