using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api
{
    public class GenerateStarSignMatchesService
    {
        private const int NUMBER_OF_MONTHS = 12;
        private Random random;
        private IEnumerable<StarSign> starSigns;
        private StarSign mainStarSign;
        private IStarSignRepository starSignRepository;
        private StarSignMatch starSignMatch;


        public GenerateStarSignMatchesService(StarSign mainStarSign, IStarSignRepository starSignRepository)
        {
            this.random = new Random();
            this.mainStarSign = mainStarSign;
            this.starSignRepository = starSignRepository;
        }

        public async Task<StarSignMatch> GetOrGenerateRandomMatch()
        {
            return await CreateStarSignMatch();
        }

        private async Task<StarSignMatch> CreateStarSignMatch()
        {
            this.starSignMatch = new StarSignMatch(this.mainStarSign);
            this.starSignMatch.DateMatched = DateTime.Now;
            this.starSignMatch.FriendshipMatch = await GenerateRandomMatchAsync();
            this.starSignMatch.CareerMatch = await GenerateRandomMatchAsync();
            this.starSignMatch.LoveMatch = await GenerateRandomMatchAsync();
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

            return await starSignRepository.GetByStartMonth(monthIndex);
        }
    }
}
