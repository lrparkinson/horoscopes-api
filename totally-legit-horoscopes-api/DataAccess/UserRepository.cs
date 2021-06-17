using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class UserRepository:GenericRepository<User>, IUserRepository
    {
        public UserRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        public async Task<User> GetUserWithFKS(long id)
        {
            return await context.Users.Include("FavoriteDinosaur")
                                      .Include("Profession")
                                      .Include("StarSign")
                                      .Include("Hobbies")
                                      .FirstAsync(user => user.UserId == id);
        }

    }
}
