using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.DataAccess;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarSignsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStarSignRepository _starSignRepository;


        public StarSignsController(IStarSignRepository starSignRepository, IMapper mapper)
        {
            _mapper = mapper;
            _starSignRepository = starSignRepository;
        }

        // GET: api/StarSigns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StarSignDTO>>> GetStarSigns()
        {
            return Ok(await _starSignRepository.GetAll());
        }

        // GET: api/StarSigns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StarSignDTO>> GetStarSign(string id)
        {
            var starSign = await _starSignRepository.GetByValue(id);

            if (starSign == null)
            {
                return NotFound();
            }

            return _mapper.Map<StarSignDTO>(starSign);
        }

        // GET: api/StarSigns/5/matches
        [HttpGet("{id}/matches")]
        public async Task<ActionResult<StarSignMatch>> GetStarSignMatch(string id)
        {
            var starSign = await _starSignRepository.GetByValue(id);

            if (starSign == null)
            {
                return NotFound();
            }

            GenerateStarSignMatchesService generateStarSignMatchesService = new GenerateStarSignMatchesService(
                                                                                    starSign,
                                                                                    _starSignRepository);

            StarSignMatch match = await generateStarSignMatchesService.GetOrGenerateRandomMatch();

            StarSignMatchDTO matchDTO =_mapper.Map<StarSignMatchDTO>(match);
            return Ok(matchDTO);
        }
    }
}
