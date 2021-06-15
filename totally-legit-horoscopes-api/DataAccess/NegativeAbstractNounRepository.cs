using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class NegativeAbstractNounRepository:GenericRepository<NegativeAbstractNoun>, INegativeAbstractNounRepository
    {
        public NegativeAbstractNounRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        async public Task<NegativeAbstractNoun> GetRandomNegativeAbstractNoun()
        {
            return context.NegativeAbstractNouns.OrderBy(x => Guid.NewGuid()).First();
            // Possible solution for table merge
            //context.PositiveAbstractNouns.OrderBy(x => Guid.NewGuid()).ThenBy(x => x.Value).First();
        }
    }
}
