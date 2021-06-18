using System;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class GeneralDailyHoroscopeBuilder : HoroscopeBuilder
    {
        public GeneralDailyHoroscopeBuilder(
            User user,
            IHoroscopeTemplateRepository horoscopeTemplateRepository,
            IStarSignRepository starSignRepository,
            IAbstractNounRepository abstractNounRepository)
            : base(
                user,
                horoscopeTemplateRepository,
                starSignRepository,
                abstractNounRepository)
        { }

        public override HoroscopeReadingTemplate GetHoroscopeTemplate()
        {
            return horoscopeTemplateRepository.GetGeneralHoroscope();
        }

        public async override Task SprinkleInMoreCustomDetails()
        {

        }
    }
}
