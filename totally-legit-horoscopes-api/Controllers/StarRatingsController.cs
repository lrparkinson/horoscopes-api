using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.Models;
namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarRatingsController : Controller
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;

        public StarRatingsController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        // GET: api/StarRatings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IDictionary<string, int>>> GetUserStarRatings(long id)
        {
            User user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(GenerateUserStarRatings(user));
        }

        private IDictionary<string, int> GenerateUserStarRatings(User user)
        {
            IQueryable<StarRatingCategories> starRatingCategories = _context.StarRatingCategories.Distinct();
            int seed = HashCode.Combine(DateTime.UtcNow.Date, user.StarSign, user.Profession, user.FavoriteDinosaur);
            Random random = new Random(seed);
            IDictionary<string, int> ratings = new Dictionary<string, int>();

            starRatingCategories.ToList().ForEach((element) =>
             {
                 ratings.Add(element.Name, random.Next(0, 5));
             });
            return ratings;
        }
    }
}
