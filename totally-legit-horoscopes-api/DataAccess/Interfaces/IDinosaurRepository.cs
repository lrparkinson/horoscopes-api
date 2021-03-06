using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IDinosaurRepository: IGenericRepository<Dinosaur>
    {
        public Task<Dinosaur>  Get(string DinosaurName);
    }
}
