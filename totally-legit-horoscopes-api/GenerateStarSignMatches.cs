using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api
{
    public class GenerateStarSignMatches
    {
        private const int NUMBER_OF_MONTHS = 12;
        private Random random;
        private IEnumerable<StarSign> starSigns;
        private User user;
        private StarSignRepository starSignRepository;
        private StarSignMatch starSignMatch;


        public GenerateStarSignMatches(User user, StarSignRepository starSignRepository)
        {
            this.random = new Random();
            this.user = user;
            this.starSignRepository = starSignRepository;
        }

        private async Task<StarSignMatch> GetOrGenerateRandomMatch()
        {
            return await CreateStarSignMatch();
        }

        private async Task<StarSignMatch> CreateStarSignMatch()
        {
            this.starSignMatch = new StarSignMatch(user.StarSign);
            starSignMatch.FriendshipMatch = await GenerateRandomMatchAsync();
            starSignMatch.CareerMatch = await GenerateRandomMatchAsync();
            starSignMatch.LoveMatch = await GenerateRandomMatchAsync();
            return starSignMatch;
        }

        private bool ValidateRandomMatchAsync(int monthIndex)
        {
            if (this.starSignMatch.MainStarSign.StartDate.Month == monthIndex
                || this.starSignMatch.LoveMatch?.StartDate.Month == monthIndex
                || this.starSignMatch.CareerMatch?.StartDate.Month == monthIndex
                || this.starSignMatch.FriendshipMatch?.StartDate.Month == monthIndex)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async Task<StarSign> GenerateRandomMatchAsync()
        {
            if (starSigns == null)
            {
                starSigns = await starSignRepository.GetAll();
            }

            int monthIndex = this.random.Next(NUMBER_OF_MONTHS) + 1;
            while (!ValidateRandomMatchAsync(monthIndex))
            {
                monthIndex = this.random.Next(NUMBER_OF_MONTHS);
            }

            return starSigns.Where(starSign => starSign.StartDate.Month == (monthIndex)).First();
        }
    }
}
