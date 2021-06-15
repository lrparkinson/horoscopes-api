using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class PositiveAbstractNounRepository:GenericRepository<PositiveAbstractNoun>
    {
        public PositiveAbstractNounRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
