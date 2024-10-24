using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>()
        {
            new User { Id = 1, Name = "Jack", Email = "jack@gmail.com", Gender = "male" },
            new User { Id = 2, Name = "Peter", Email = "peter@gmail.com", Gender = "male" },
            new User { Id = 3, Name = "Mary", Email = "mary@gmail.com", Gender = "female" },
            new User { Id = 4, Name = "Smith", Email = "smith@gmail.com", Gender = "male" },
            new User { Id = 5, Name = "John", Email = "john@gmail.com", Gender = "male" }
        };

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            user.Id = users.Max(u => u.Id) + 1;
            users.Add(user);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();

            users.Remove(user);
            return Ok();
        }
    }
}
