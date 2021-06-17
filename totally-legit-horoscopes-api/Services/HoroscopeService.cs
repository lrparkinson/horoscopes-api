using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.HoroscopeBuilder;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Services
{
    public class HoroscopeService : IHoroscopeServices
    {
        private readonly IHoroscopeRepository _horoscopeRepository;
        private readonly IHoroscopeTemplateRepository _horoscopeTemplateRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAbstractNounRepository _abstractNounRepository;

        public HoroscopeService(
            IHoroscopeRepository horoscopeRepository,
            IHoroscopeTemplateRepository horoscopeTemplateRepository,
            IAbstractNounRepository abstractNounRepository,
            IStarSignRepository starSignRepository,
            IUserRepository userRepository
            )
        {
            _horoscopeRepository = horoscopeRepository;
            _horoscopeTemplateRepository = horoscopeTemplateRepository;
            _userRepository = userRepository;
            _abstractNounRepository = abstractNounRepository;

        }

        public async Task<Horoscope> CreateGeneralHoroscope(User user)
        {
            GeneralDailyHoroscopeBuilder horoscopeBuilder = new GeneralDailyHoroscopeBuilder(
                                                                user,
                                                                _horoscopeTemplateRepository,
                                                                _abstractNounRepository);
            HoroscopeDirector horoscopeDirector = new HoroscopeDirector(horoscopeBuilder);
            horoscopeDirector.ConstructFullHoroscope();
            Horoscope horoscope = horoscopeDirector.GetHoroscope();
            await _horoscopeRepository.Add(horoscope);
            await _horoscopeRepository.Save();
            return horoscope;
        }

        public async Task<Horoscope> CreateLoveHoroscope(User user)
        {
            LoveDailyHoroscopeBuilder horoscopeBuilder = new LoveDailyHoroscopeBuilder(
                                                               user,
                                                               _horoscopeTemplateRepository,
                                                               _abstractNounRepository);
            HoroscopeDirector horoscopeDirector = new HoroscopeDirector(horoscopeBuilder);
            horoscopeDirector.ConstructFullHoroscope();
            Horoscope horoscope = horoscopeDirector.GetHoroscope();
            await _horoscopeRepository.Add(horoscope);
            await _horoscopeRepository.Save();
            return horoscope;
        }

        public async Task<Horoscope> CreateCareerHoroscope(User user)
        {
            CareerDailyHoroscopeBuilder horoscopeBuilder = new CareerDailyHoroscopeBuilder(
                                                               user,
                                                               _horoscopeTemplateRepository,
                                                               _abstractNounRepository);
            HoroscopeDirector horoscopeDirector = new HoroscopeDirector(horoscopeBuilder);
            horoscopeDirector.ConstructFullHoroscope();
            Horoscope horoscope = horoscopeDirector.GetHoroscope();
            await _horoscopeRepository.Add(horoscope);
            await _horoscopeRepository.Save();
            return horoscope;
        }

        public async Task<List<Horoscope>> GetPastHoroscopes(long userId)
        {
            return await _horoscopeRepository.GetPastHoroscopes(userId);
        }
    }
}
