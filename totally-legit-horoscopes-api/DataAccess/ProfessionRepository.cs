using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class ProfessionRepository:GenericRepository<Profession>, IProfessionRepository
    {
        public ProfessionRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
