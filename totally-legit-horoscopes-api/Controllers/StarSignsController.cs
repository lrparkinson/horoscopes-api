using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarSignsController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;

        public StarSignsController(TotallyLegitHoroscopesContext context)
        {
            _context = context;
        }

        // GET: api/StarSigns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StarSign>>> GetStarSigns()
        {
            return await _context.StarSigns.ToListAsync();
        }

        // GET: api/StarSigns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StarSign>> GetStarSign(string id)
        {
            var starSign = await _context.StarSigns.FindAsync(id);

            if (starSign == null)
            {
                return NotFound();
            }

            return starSign;
        }
    }
}
