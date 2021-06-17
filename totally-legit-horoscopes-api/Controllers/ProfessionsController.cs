using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IList<Profession>>> GetProfessions()
        {
            IEnumerable<Profession> professions = await _professionRepository.GetAll();
            return professions.ToList();
        }
    }
}
