using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class HoroscopeTemplateRepository : GenericRepository<HoroscopeReadingTemplate>, IHoroscopeTemplateRepository
    {
        public HoroscopeTemplateRepository(TotallyLegitHoroscopesContext context):base(context)
        {

        }

        public HoroscopeReadingTemplate GetGeneralHoroscope()
        {
            return context.HoroscopeReadingTemplates.Where(horoscopeTemplate => horoscopeTemplate.Category.Equals("General"))
                                                    .OrderBy(x => Guid.NewGuid()).First();
        }

        public HoroscopeReadingTemplate GetLoveHoroscope()
        {
            return context.HoroscopeReadingTemplates.Where(horoscopeTemplate => horoscopeTemplate.Category.Equals("Love"))
                                                    .OrderBy(x => Guid.NewGuid()).First();
        }

        public HoroscopeReadingTemplate GetCareerHoroscope()
        {
            return context.HoroscopeReadingTemplates.Where(horoscopeTemplate => horoscopeTemplate.Category.Equals("Career"))
                                                    .OrderBy(x => Guid.NewGuid()).First();
        }
    }
}
