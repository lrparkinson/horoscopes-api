using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.DataAccess;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarSignsController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;
        private readonly IStarSignRepository starSignRepository;


        public StarSignsController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            starSignRepository = new StarSignRepository(_context);
        }

        // GET: api/StarSigns
        [HttpGet]
        public async Task<IEnumerable<StarSignDTO>> GetStarSigns()
        {
            IEnumerable<StarSign> starSigns = await starSignRepository.GetAll();
            return starSigns.Select(profession => _mapper.Map<StarSignDTO>(profession));
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
