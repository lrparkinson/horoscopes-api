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
        private readonly IStarSignMatchRepository _starSignMatchRepository;
        private readonly IStarSignRepository _starSignRepository;

        public HoroscopeService(
            IHoroscopeRepository horoscopeRepository,
            IHoroscopeTemplateRepository horoscopeTemplateRepository,
            IAbstractNounRepository abstractNounRepository,
            IStarSignMatchRepository starSignMatchRepository,
            IStarSignRepository starSignRepository,
            IUserRepository userRepository
            )
        {
            _horoscopeRepository = horoscopeRepository;
            _horoscopeTemplateRepository = horoscopeTemplateRepository;
            _userRepository = userRepository;
            _abstractNounRepository = abstractNounRepository;
            _starSignMatchRepository = starSignMatchRepository;
            _starSignRepository = starSignRepository;

        }

        public async Task<Horoscope> CreateOrGetGeneralHoroscope(User user)
        {
            Horoscope horoscope = await _horoscopeRepository.GetPastHoroscopeForDayAndType(user.UserId, DateTime.Now.Date, "General");
            if (horoscope == null)
            {
                GeneralDailyHoroscopeBuilder horoscopeBuilder = new GeneralDailyHoroscopeBuilder(
                                                                    user,
                                                                    _horoscopeTemplateRepository,
                                                                    _starSignRepository,
                                                                    _abstractNounRepository);
                HoroscopeDirector horoscopeDirector = new HoroscopeDirector(horoscopeBuilder);
                await horoscopeDirector.ConstructFullHoroscope();
                horoscope = horoscopeDirector.GetHoroscope();
                await _horoscopeRepository.Add(horoscope);
                await _horoscopeRepository.Save();
            }

            return horoscope;
        }

        public async Task<Horoscope> CreateOrGetLoveHoroscope(User user)
        {
            Horoscope horoscope = await _horoscopeRepository.GetPastHoroscopeForDayAndType(user.UserId, DateTime.Now.Date, "Love");
            if (horoscope == null)
            {
                LoveDailyHoroscopeBuilder horoscopeBuilder = new LoveDailyHoroscopeBuilder(
                                                               user,
                                                               _horoscopeTemplateRepository,
                                                               _starSignMatchRepository,
                                                               _starSignRepository,
                                                               _abstractNounRepository);
                HoroscopeDirector horoscopeDirector = new HoroscopeDirector(horoscopeBuilder);
                await horoscopeDirector.ConstructFullHoroscope();
                horoscope = horoscopeDirector.GetHoroscope();
                await _horoscopeRepository.Add(horoscope);
                await _horoscopeRepository.Save();
            }

            return horoscope;
        }

        public async Task<Horoscope> CreateOrGetCareerHoroscope(User user)
        {
            Horoscope horoscope = await _horoscopeRepository.GetPastHoroscopeForDayAndType(user.UserId, DateTime.Now.Date, "Career");
            if (horoscope == null)
            {
                CareerDailyHoroscopeBuilder horoscopeBuilder = new CareerDailyHoroscopeBuilder(
                                                               user,
                                                               _horoscopeTemplateRepository,
                                                               _starSignRepository,
                                                               _abstractNounRepository);
                HoroscopeDirector horoscopeDirector = new HoroscopeDirector(horoscopeBuilder);
                await horoscopeDirector.ConstructFullHoroscope();
                horoscope = horoscopeDirector.GetHoroscope();
                await _horoscopeRepository.Add(horoscope);
                await _horoscopeRepository.Save();
            }

            return horoscope;
        }

        public async Task<List<Horoscope>> GetPastHoroscopes(long userId)
        {
            return await _horoscopeRepository.GetPastHoroscopes(userId);
        }
    }
}
