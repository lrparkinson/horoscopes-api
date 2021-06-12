using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class UserRepository:GenericRepository<User>, IUserRepository
    {
        public StarSignRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
