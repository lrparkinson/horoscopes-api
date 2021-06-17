using System.Collections.Generic;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IHoroscopeRepository:IGenericRepository<Horoscope>
    {
        public Task<List<Horoscope>> GetPastHoroscopes(long userId);
    }
}
