﻿using System;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class LoveDailyHoroscopeBuilder : HoroscopeBuilder
    {
        public LoveDailyHoroscopeBuilder(
            User user,
            HoroscopeTemplateRepository horoscopeTemplateRepository,
            PositiveAbstractNounRepository positiveAbstractNounRepository,
            NegativeAbstractNounRepository negativeAbstractNounRepository)
            : base(
                user,
                horoscopeTemplateRepository,
                positiveAbstractNounRepository,
                negativeAbstractNounRepository)
        { }

        public override HoroscopeReadingTemplate GetHoroscopeTemplate()
        {
            return horoscopeTemplateRepository.GetLoveHoroscope();
        }
    }
}
