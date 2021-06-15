using System;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class LoveDailyHoroscopeBuilder : HoroscopeBuilder
    {
        public LoveDailyHoroscopeBuilder(
            HoroscopeTemplateRepository horoscopeTemplateRepository,
            PositiveAbstractNounRepository positiveAbstractNounRepository,
            NegativeAbstractNounRepository negativeAbstractNounRepository)
            : base(
                horoscopeTemplateRepository,
                positiveAbstractNounRepository,
                negativeAbstractNounRepository)
        { }

        public override Horoscope CreateHoroscopeBase()
        {
            SetupKnownDataDictionary();

            horoscope.ReadingDate = DateTime.Now;
            horoscope.User = this.user;
            horoscope.Reading = "Read in Love Horoscope";
            return horoscope;
        }

        public override void SetCategory()
        {
            horoscope.Category = "Love";
        }
    }
}
