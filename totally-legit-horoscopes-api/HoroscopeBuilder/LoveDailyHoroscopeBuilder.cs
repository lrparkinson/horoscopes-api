using System;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class LoveDailyHoroscopeBuilder : HoroscopeBuilder
    {
        public LoveDailyHoroscopeBuilder(
            User user,
            IHoroscopeTemplateRepository horoscopeTemplateRepository,
            IAbstractNounRepository abstractNounRepository)
            : base(
                user,
                horoscopeTemplateRepository,
                abstractNounRepository)
        { }

        public override HoroscopeReadingTemplate GetHoroscopeTemplate()
        {
            return horoscopeTemplateRepository.GetLoveHoroscope();
        }
    }
}
