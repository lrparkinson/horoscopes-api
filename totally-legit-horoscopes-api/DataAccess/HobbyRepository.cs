using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class HobbyRepository : GenericRepository<Hobby>, IHobbyRepository
    {
        public HobbyRepository(TotallyLegitHoroscopesContext context) : base(context)
        {
        }

        public async Task<bool> Delete(string Name)
        {
            Hobby hobby = await Get(Name);
            context.Set<Hobby>().Remove(hobby);
            context.Entry(hobby).State = EntityState.Deleted;
            return true;
        }

        public async Task<Hobby> Get(string Name)
        {
            Hobby hobby = await context.Set<Hobby>().FindAsync(Name);
            return hobby;
        }
    }
}
