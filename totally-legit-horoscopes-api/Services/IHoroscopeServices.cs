using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Services
{
    public interface IHoroscopeServices
    {
        public Task<Horoscope> CreateOrGetGeneralHoroscope(User user);
        public Task<Horoscope> CreateOrGetLoveHoroscope(User user);
        public Task<Horoscope> CreateOrGetCareerHoroscope(User user);
        public Task<List<Horoscope>> GetPastHoroscopes(long userId);
    }
}
