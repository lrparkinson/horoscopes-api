using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoroscopeReadingTemplatesController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;

        public HoroscopeReadingTemplatesController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/HoroscopeReadingTemplates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HoroscopeReadingTemplateDTO>>> GetHoroscopeReadingTemplates()
        {
            return await _context.HoroscopeReadingTemplates.Select(HoroscopeReadingTemplate => _mapper.Map<HoroscopeReadingTemplateDTO>(HoroscopeReadingTemplate))
                                                           .ToListAsync();
        }

        // GET: api/HoroscopeReadingTemplates/General
        [HttpGet("General")]
        public async Task<ActionResult<IEnumerable<HoroscopeReadingTemplateDTO>>> GetGeneralHoroscopeReadingTemplates()
        {
            return await _context.HoroscopeReadingTemplates.Where(horoscopeTemplate => horoscopeTemplate.Category.Equals("General"))
                                                            .Select(HoroscopeReadingTemplate => _mapper.Map<HoroscopeReadingTemplateDTO>(HoroscopeReadingTemplate))
                                                            .ToListAsync();
        }

        // GET: api/HoroscopeReadingTemplates/Love
        [HttpGet("Love")]
        public async Task<ActionResult<IEnumerable<HoroscopeReadingTemplateDTO>>> GetLoveHoroscopeReadingTemplates()
        {
            return await _context.HoroscopeReadingTemplates.Where(horoscopeTemplate => horoscopeTemplate.Category.Equals("Love"))
                                                           .Select(HoroscopeReadingTemplate => _mapper.Map<HoroscopeReadingTemplateDTO>(HoroscopeReadingTemplate))
                                                           .ToListAsync();
        }

        // GET: api/HoroscopeReadingTemplates/Career
        [HttpGet("Career")]
        public async Task<ActionResult<IEnumerable<HoroscopeReadingTemplateDTO>>> GetCareerHoroscopeReadingTemplates()
        {
            return await _context.HoroscopeReadingTemplates.Where(horoscopeTemplate => horoscopeTemplate.Category.Equals("Career"))
                                                           .Select(HoroscopeReadingTemplate => _mapper.Map<HoroscopeReadingTemplateDTO>(HoroscopeReadingTemplate))
                                                           .ToListAsync();
        }
    }
}
