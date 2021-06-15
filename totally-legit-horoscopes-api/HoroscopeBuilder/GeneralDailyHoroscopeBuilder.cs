using System;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class GeneralDailyHoroscopeBuilder : HoroscopeBuilder
    {
        public GeneralDailyHoroscopeBuilder(
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

            int templateNumber = random.Next(2);
            horoscope.ReadingDate = DateTime.Now;
            horoscope.User = this.user;
            //TODO: get from DB
            horoscope.Reading = "Read in General Horoscope";
            return horoscope;
        }

        public override void SetCategory()
        {
            horoscope.Category = "General";
        }
    }
}
