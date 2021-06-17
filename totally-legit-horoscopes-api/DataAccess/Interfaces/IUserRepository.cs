using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IUserRepository:IGenericRepository<User>
    {

        public Task<User> GetUserWithFKS(long id);
    }
}
