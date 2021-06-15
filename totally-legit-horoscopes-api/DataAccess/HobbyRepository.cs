using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class HobbyRepository:GenericRepository<Hobby>, IHobbyRepository
    {
        public HobbyRepository(TotallyLegitHoroscopesContext context) : base(context)
        {
        }
    }
}
