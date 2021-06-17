using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class StarRatingsRepository : GenericRepository<StarRatingCategory>, IStarRatingsRepository
    {
        public StarRatingsRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
