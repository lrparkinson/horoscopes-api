using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class AbstractNounRepository:GenericRepository<AbstractNoun>, IAbstractNounRepository
    {
        public AbstractNounRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        public async Task<AbstractNoun> GetRandomAbstractNoun(bool shouldGetPositiveNoun)
        {
            return await context.AbstractNouns.Where(noun => noun.IsPositive == shouldGetPositiveNoun).OrderBy(x => Guid.NewGuid()).FirstAsync();
        }
    }
}
