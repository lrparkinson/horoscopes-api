using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class StarSignRepository : GenericRepository<StarSign>, IStarSignRepository
    {
        public StarSignRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        public async Task<StarSign> GetByDate(DateTime date)
        {
            return await context.StarSigns.SingleOrDefaultAsync(x => x.StartDate <= date && date <= x.EndDate);
        }

        public async Task<StarSign> GetByValue(string name)
        {
            return await context.StarSigns.SingleOrDefaultAsync(x => x.Name.Equals(name));
        }

        public async Task<StarSign> GetByStartMonth(int monthIndex)
        {
            return await context.StarSigns.SingleOrDefaultAsync(starSign => starSign.StartDate.Month == (monthIndex));
        }

        public async Task<StarSign> GetRandomStarSign(string excludeThisStarSign)
        {
            return await context.StarSigns.OrderBy(x => Guid.NewGuid()).Where(x => !x.Name.Equals(excludeThisStarSign)).FirstOrDefaultAsync();
        }

    }
}
