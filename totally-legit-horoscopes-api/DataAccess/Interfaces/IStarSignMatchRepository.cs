using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IStarSignMatchRepository : IGenericRepository<StarSignMatch>
    {
        public Task<StarSignMatch> GetOrCreateStarSignMatch(StarSign starSign, IStarSignRepository starSignRepository);
    }
}
