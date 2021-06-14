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
        public async Task<ActionResult<List<UserStarRatings>>> GetUserStarRatings(long id)
        {
            User user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            //Get all ratings for today for a given user
            List<UserStarRatings> userStarRatings = user.StarRatings.Where( element => { return element.CreatedDate.Date.CompareTo(System.DateTime.UtcNow.Date) == 0; })
                                                    .Select(element => _mapper.Map<UserStarRatings>(element)).ToList();
            //If there are already ratings, then return them
            if(userStarRatings.Count != 0)
            {
                return userStarRatings;
            }

            //Otherwise, generate ratings
            List<UserStarRatings> generatedRatings = generateUserStarRatings(user);

            generatedRatings.ForEach(element =>
            {
                _context.UserStarRatings.Add(element);
            });
            _context.SaveChanges();

            return generatedRatings;
        }

        private List<UserStarRatings> generateUserStarRatings( User user)
        {
            IQueryable<StarRatingCategories> starRatingCategories = _context.StarRatingCategories.Distinct();

            List<UserStarRatings> starRatings = starRatingCategories.Select(element => new UserStarRatings(user, element, new Random().Next(0, 5))).ToList();
            return starRatings;
        }
    }
}
