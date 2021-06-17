using System;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class LoveDailyHoroscopeBuilder : HoroscopeBuilder
    {
        private IStarSignMatchRepository starSignMatchRepository;
        private IStarSignRepository starSignRepository;
        private const string abstractNounKey = "{abstract_noun}";
        private Random random;

        public LoveDailyHoroscopeBuilder(
            User user,
            IHoroscopeTemplateRepository horoscopeTemplateRepository,
            IStarSignMatchRepository starSignMatchRepository,
            IStarSignRepository starSignRepository,

            IAbstractNounRepository abstractNounRepository)
            : base(
                user,
                horoscopeTemplateRepository,
                abstractNounRepository)
        {
            int seed = HashCode.Combine(DateTime.UtcNow.Date, user.StarSign, user.NthChild, user.Profession, user.FavoriteDinosaur);
            this.random = new Random(seed);
            this.starSignMatchRepository = starSignMatchRepository;
            this.starSignRepository = starSignRepository;
        }

        public override HoroscopeReadingTemplate GetHoroscopeTemplate()
        {
            return horoscopeTemplateRepository.GetLoveHoroscope();
        }

        public async override void PopulateRandomWords()
        {
            base.PopulateRandomWords();

            if (this.horoscope.Reading.Contains(abstractNounKey))
            {
                double weightedPositivity = this.random.Next(1);
                bool luckyInLove = false;
                if (weightedPositivity > 0.5)
                {
                    luckyInLove = true;
                }

                string abstractNoun = (await abstractNounRepository.GetRandomAbstractNoun(luckyInLove)).Value.ToLower();

                this.horoscope.Reading = this.horoscope.Reading.Replace(abstractNounKey, abstractNoun);
            }
        }

        public async override void SprinkleInMoreCustomDetails()
        {
            StarSignMatch match = await this.starSignMatchRepository.GetOrCreateStarSignMatch(this.user.StarSign, this.starSignRepository);
            this.horoscope.Reading += string.Format(" Hint: Look to {0} today!", match.LoveMatch.Name);
        }
    }
}
