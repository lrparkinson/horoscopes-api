using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class HoroscopeRepository: GenericRepository<Horoscope>, IHoroscopeRepository
    {
        public HoroscopeRepository(TotallyLegitHoroscopesContext context) : base(context)
        {
        }

        public async Task<List<Horoscope>> GetPastHoroscopes(long userId)
        {
            return await context.Horoscopes.Where(horoscope => horoscope.UserId == userId).ToListAsync();
        }

        public async Task<Horoscope> GetPastHoroscopeForDayAndType(long userId, DateTime dateOfReading, string category)
        {
            return await context.Horoscopes.Where(horoscope => horoscope.UserId == userId
                                                               && horoscope.ReadingDate.Date == dateOfReading.Date
                                                               && horoscope.Category.Equals(category)).FirstOrDefaultAsync();
        }
    }
}
