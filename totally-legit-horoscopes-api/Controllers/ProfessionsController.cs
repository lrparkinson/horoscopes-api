using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionsController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;

        public ProfessionsController(TotallyLegitHoroscopesContext context)
        {
            _context = context;
        }

        // GET: api/Professions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profession>>> GetProfessions()
        {
            return await _context.Professions.ToListAsync();
        }

    }
}
