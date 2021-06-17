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
            }

            return match;
        }

        private async Task<StarSignMatch> GetStarSignMatch(DateTime dateTime, StarSign starSign)
        {
            return await context.StarSignMatches.Where(starSignMatch => starSignMatch.DateMatched.Date == dateTime.Date
                                                                        && starSignMatch.MainStarSign == starSign).FirstOrDefaultAsync();
        }
    }
}
