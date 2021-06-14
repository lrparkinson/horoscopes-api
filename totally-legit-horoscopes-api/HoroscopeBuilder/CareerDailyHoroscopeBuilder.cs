using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class CareerDailyHoroscopeBuilder : HoroscopeBuilder
    {
        public override Horoscope CreateHoroscopeBase()
        {
            SetupKnownDataDictionary();

            horoscope.ReadingDate = DateTime.Now;
            horoscope.User = this.user;
            //TODO: get from DB
            horoscope.Reading = "Read in Career Horoscope";
            return horoscope;
        }

        public override void SetCategory()
        {
            horoscope.Category = "Career";
        }
    }
}
