using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User> GetByEmail(string Email);
        new public Task<bool> Update(User user);
    }

}
