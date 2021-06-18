using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class LifeNumberRepository : GenericRepository<LifeNumber>, ILifeNumberRepository
    {
        public LifeNumberRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
        public async override Task<LifeNumber> Get(long id)
        {
            LifeNumber entity = await context.Set<LifeNumber>().FindAsync(System.Convert.ToInt32(id));
            return entity;
        }

    }
}
