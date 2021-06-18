using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IHobbyRepository:IGenericRepository<Hobby>
    {
        public Task<bool> Delete(string Name);
        public Task<Hobby>  Get(string Name);
    }
}
