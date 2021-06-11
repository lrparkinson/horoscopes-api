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
    public class HobbiesController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;

        public HobbiesController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Hobbies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HobbyDTO>>> GetHobbies()
        {
            return await _context.Hobbies.Select(hobby => _mapper.Map<HobbyDTO>(hobby)).ToListAsync();
        }
    }
}
