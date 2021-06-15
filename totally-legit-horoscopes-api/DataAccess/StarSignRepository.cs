using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class StarSignRepository:GenericRepository<StarSign>, IStarSignRepository
    {
        public StarSignRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        public async Task<StarSign> getByDate(DateTime date)
        {
            return await context.StarSigns.SingleAsync(x => x.StartDate <= date && date <= x.EndDate);
        }
    }
}
