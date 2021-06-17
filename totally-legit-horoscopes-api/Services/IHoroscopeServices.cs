using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Services
{
    public interface IHoroscopeServices
    {
        public Task<Horoscope> CreateGeneralHoroscope(User user);
        public Task<Horoscope> CreateLoveHoroscope(User user);
        public Task<Horoscope> CreateCareerHoroscope(User user);
        public Task<List<Horoscope>> GetPastHoroscopes(long userId);
    }
}
