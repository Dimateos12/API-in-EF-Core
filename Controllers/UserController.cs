using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static ApiDbContext _context;
        public UserController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _context.Users.ToListAsync();

            if (users == null)
            {
                return BadRequest("Invalid Id");
            }

            return Ok(users);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x=>x.Id== id);

            if (user == null)
            {
                return BadRequest("Invalid id");
            }

            return Ok(user);

        }

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            await _context.AddAsync(user);  
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", user.Id, user); //Return new created user 
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var user = _context.Users.FirstOrDefaultAsync(x => x.Id == id).Result;

            if (user == null) return null;

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

            return NoContent();

        }

    }
}
