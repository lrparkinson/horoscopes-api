using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class NegativeAbstractNounRepository:GenericRepository<NegativeAbstractNoun>
    {
        public NegativeAbstractNounRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
