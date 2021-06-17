using System.Collections.Generic;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(long id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Add(T entity);
        Task<bool> Delete(long id);
        Task<bool> Update(T entity);
        void Save();

    }
}
