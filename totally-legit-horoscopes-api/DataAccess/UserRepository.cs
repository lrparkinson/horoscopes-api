using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class UserRepository:GenericRepository<User>, IUserRepository
    {
        public UserRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
