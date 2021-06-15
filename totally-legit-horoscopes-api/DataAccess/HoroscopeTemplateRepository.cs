using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class HoroscopeTemplateRepository : GenericRepository<HoroscopeReadingTemplate>, IHoroscopeTemplateRepository
    {
        public HoroscopeTemplateRepository(TotallyLegitHoroscopesContext context):base(context)
        {
        }
    }
}
