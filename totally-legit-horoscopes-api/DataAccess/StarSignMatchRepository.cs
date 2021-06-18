using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class StarSignMatchRepository:GenericRepository<StarSignMatch>, IStarSignMatchRepository
    {
        public StarSignMatchRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        public async Task<StarSignMatch> GetOrCreateStarSignMatch(StarSign starSign, IStarSignRepository starSignRepository)
        {
            StarSignMatch match = await GetStarSignMatch(DateTime.Now, starSign);
            if (match == null)
            {
                GenerateStarSignMatchesService generateStarSignMatchesService = new GenerateStarSignMatchesService(
                                                                                    starSign,
                                                                                    starSignRepository);
                match = await generateStarSignMatchesService.CreateStarSignMatch();
                context.Add(match);
                context.Entry(match.MainStarSign).State = EntityState.Unchanged;
                context.Entry(match.LoveMatch).State = EntityState.Unchanged;
                context.Entry(match.CareerMatch).State = EntityState.Unchanged;
                context.Entry(match.FriendshipMatch).State = EntityState.Unchanged;
                await context.SaveChangesAsync();
            }

            return match;
        }

        private async Task<StarSignMatch> GetStarSignMatch(DateTime dateTime, StarSign starSign)
        {
            return await context.StarSignMatches.Include(e => e.MainStarSign)
                                                .Include(e => e.LoveMatch)
                                                .Include(e => e.CareerMatch)
                                                .Include(e => e.FriendshipMatch)
                                                .Where(starSignMatch => starSignMatch.DateMatched.Date == dateTime.Date
                                                                        && starSignMatch.MainStarSign == starSign).FirstOrDefaultAsync();
        }
    }
}
