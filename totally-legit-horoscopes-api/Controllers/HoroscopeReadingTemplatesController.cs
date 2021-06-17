using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.DTOs;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoroscopeReadingTemplatesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHoroscopeTemplateRepository _horoscopeTemplateRepository;

        public HoroscopeReadingTemplatesController(IHoroscopeTemplateRepository horoscopeTemplateRepository, IMapper mapper)
        {
            _mapper = mapper;
            _horoscopeTemplateRepository = horoscopeTemplateRepository;
        }
    }
}
