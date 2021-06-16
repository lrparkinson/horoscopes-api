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
    public class HobbiesController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;
        private readonly IHobbyRepository hobbyRepository;

        public HobbiesController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            hobbyRepository = new HobbyRepository(context);
        }

        // GET: api/Hobbies
        [HttpGet]
        public async Task<IEnumerable<HobbyDTO>> GetHobbies()
        {
            IEnumerable<Hobby> hobbies = await hobbyRepository.GetAll();

            return hobbies.Select(hobby => _mapper.Map<HobbyDTO>(hobby));
        }
    }
}
