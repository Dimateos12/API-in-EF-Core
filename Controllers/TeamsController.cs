using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private static ApiDbContext _context;

        public TeamsController(ApiDbContext context) {
            _context = context;   
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var team = await _context.Teams.ToListAsync();

            if (team == null)
            {
                return BadRequest("Invalid Id");
            }

            return Ok(team);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id) {

            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
           

            if (team == null)
            {
                return BadRequest("Invalid Id");
            }

            return Ok(team);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Team team)
        {
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", team.Id, team);
        }

        [HttpPatch]
        public async Task<IActionResult> Patch(int id, string country) {

            var team = _context.Teams.FirstOrDefaultAsync(x => x.Id == id).Result;
            
            if (team == null) return BadRequest("Invalid id");
            
            team.Country = country;
            
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) {
            var team = _context.Teams.FirstOrDefaultAsync(x => x.Id == id).Result;

            if (team == null) return null;

             _context.Teams.Remove(team);

            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
