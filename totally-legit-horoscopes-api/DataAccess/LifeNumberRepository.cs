using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class LifeNumberRepository:GenericRepository<LifeNumber>, ILifeNumberRepository
    {
        public LifeNumberRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
