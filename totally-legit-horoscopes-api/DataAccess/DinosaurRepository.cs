using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class DinosaurRepository : GenericRepository<Dinosaur>, IDinosaurRepository
    {
        public DinosaurRepository(TotallyLegitHoroscopesContext context) : base(context)
        {
        }
        public async Task<Dinosaur> Get(string DinosaurName)
        {
            Dinosaur dinosaur = await context.Set<Dinosaur>().FindAsync(DinosaurName);
            context.Entry(dinosaur).State = EntityState.Unchanged;
            return dinosaur;
        }

    }
}
