using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.DataAccess;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinosaursController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;
        private readonly IDinosaurRepository dinosaurRepository;

        public DinosaursController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            dinosaurRepository = new DinosaurRepository(context);
        }

        // GET: api/Dinosaurs
        [HttpGet]
        public async Task<IEnumerable<DinosaurDTO>> getDinosaurs()
        {
            IEnumerable<Dinosaur> dinosaurs = await dinosaurRepository.GetAll();

            return dinosaurs.Select(dinosaur => _mapper.Map<DinosaurDTO>(dinosaur));
        }
    }
}
