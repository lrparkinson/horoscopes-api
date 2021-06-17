using totally_legit_horoscopes_api.Models;
using System.Threading.Tasks;
using System;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IStarSignRepository : IGenericRepository<StarSign>
    {
        Task<StarSign> GetByDate(DateTime date);
        public Task<StarSign> GetByValue(string name);
        public Task<StarSign> GetByStartMonth(int monthIndex);

    }
}
