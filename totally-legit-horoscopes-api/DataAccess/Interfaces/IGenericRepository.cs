using System.Collections.Generic;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Add(T entity);
        Task<bool> Delete(int id);
        Task<bool> Update(T entity);
        Task<bool> Save();

    }
}
