using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarSignsController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;

        public StarSignsController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/StarSigns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StarSignDTO>>> GetStarSigns()
        {
            return await _context.StarSigns.Select(sign => _mapper.Map<StarSignDTO>(sign)).ToListAsync();
        }

        // GET: api/StarSigns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StarSignDTO>> GetStarSign(string id)
        {
            var starSign = await _context.StarSigns.FindAsync(id);

            if (starSign == null)
            {
                return NotFound();
            }

            return _mapper.Map<StarSignDTO>(starSign);
        }
    }
}
