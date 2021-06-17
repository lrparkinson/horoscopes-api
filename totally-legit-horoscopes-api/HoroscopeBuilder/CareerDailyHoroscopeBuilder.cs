using System;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class CareerDailyHoroscopeBuilder : HoroscopeBuilder
    {
        private Random random;
        private const double SMALL_PROBABILITY = 0.15;

        public CareerDailyHoroscopeBuilder(
            User user,
            IHoroscopeTemplateRepository horoscopeTemplateRepository,
            IStarSignRepository starSignRepository,
            IAbstractNounRepository abstractNounRepository)
            : base(
                user,
                horoscopeTemplateRepository,
                starSignRepository,
                abstractNounRepository)
        {
            this.random = new Random();
        }

        public override HoroscopeReadingTemplate GetHoroscopeTemplate()
        {
            return horoscopeTemplateRepository.GetCareerHoroscope();
        }

        public async override Task SprinkleInMoreCustomDetails()
        {
            double probabilityChildhoodDrama = this.random.NextDouble();
            if (probabilityChildhoodDrama < SMALL_PROBABILITY)
            {
                string nthChildDetails = (user.NthChild <= 1)
                                                ? " Being an only child means you're able to stand on your own 2 feet. Leverage this."
                                                : " Being one of " + user.NthChild.ToString() + " children means you have experience delegating. Use it to thrive in you career.";
                this.horoscope.Reading += nthChildDetails;
            }

            return;
        }
    }
}
