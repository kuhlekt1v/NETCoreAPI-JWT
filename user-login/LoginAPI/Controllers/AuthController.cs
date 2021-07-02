using LoginAPI.Data;
using LoginAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly ApiDbContext _context;
        public AuthController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            _context.Users.Add(user);
            await  _context.SaveChangesAsync();

            return Ok("Success!");
        }
    }
}