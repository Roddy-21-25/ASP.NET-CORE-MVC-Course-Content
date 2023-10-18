using IntroASPMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroASPMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBeersController : ControllerBase
    {
        private readonly PubContext _context;

        public ApiBeersController(PubContext context)
        {
            _context = context;
        }

        public async Task<List<Beer>> Get()
            => await _context.Beers.ToListAsync();
    }
}
