using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;
using System.Linq;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProfessionRepository _professionRepository;

        public ProfessionsController(IProfessionRepository professionRepository, IMapper mapper)
        {
            _mapper = mapper;
            _professionRepository = professionRepository;
        }

        // GET: api/Professions
        [HttpGet]
        public async Task<IEnumerable<ProfessionDTO>> GetProfessions()
        {
            IEnumerable<Profession> professions = await _professionRepository.GetAll();
            return professions.Select(profession => _mapper.Map<ProfessionDTO>(profession));
        }
    }
}
