using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using totally_legit_horoscopes_api.Contexts;
using System.Linq;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionsController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;
        private readonly IProfessionRepository professionRepository;

        public ProfessionsController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            professionRepository = new ProfessionRepository(_context);
        }
        public ActionResult<IList<Profession>> GetProfessions()
        {
            return _context.Professions.ToList();
        }

    }
}
