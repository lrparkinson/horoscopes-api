using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class PositiveAbstractNounRepository:GenericRepository<PositiveAbstractNoun>, IPositiveAbstractNounRepository
    {
        public PositiveAbstractNounRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        async public Task<PositiveAbstractNoun> GetRandomPositiveAbstractNoun()
        {
            return context.PositiveAbstractNouns.OrderBy(x => Guid.NewGuid()).First();
            // Possible solution for table merge
            //context.PositiveAbstractNouns.OrderBy(x => Guid.NewGuid()).ThenBy(x => x.Value).First();
        }
    }
}
