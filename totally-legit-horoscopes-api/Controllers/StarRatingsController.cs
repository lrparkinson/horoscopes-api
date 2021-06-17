using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;
namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarRatingsController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IStarRatingsRepository _starRatingsRepository;
        private readonly long userId = 1;

        public StarRatingsController(IUserRepository userRepository, IStarRatingsRepository starRatingsRepository)
        {
            _userRepository = userRepository;
            _starRatingsRepository = starRatingsRepository;
        }

        // GET: api/StarRatings
        [HttpGet]
        public async Task<ActionResult<IDictionary<string, int>>> GetUserStarRatings()
        {
            User user = await _userRepository.Get(userId);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(await GenerateUserStarRatings(user));
        }

        private async Task<IDictionary<string, int>> GenerateUserStarRatings(User user)
        {
            IEnumerable<StarRatingCategory> starRatingCategories = await _starRatingsRepository.GetAll();
            int seed = HashCode.Combine(DateTime.UtcNow.Date, user.StarSign, user.Profession, user.FavoriteDinosaur);
            Random random = new Random(seed);
            IDictionary<string, int> ratings = new Dictionary<string, int>();

            starRatingCategories.ToList().ForEach((element) =>
             {
                 ratings.Add(element.Name, random.Next(0, 6));
             });
            return ratings;
        }
    }
}