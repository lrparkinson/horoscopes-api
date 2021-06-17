using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Contexts;
using Microsoft.EntityFrameworkCore;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class GenericRepository<T>: IGenericRepository<T> where T: class
    {
        protected readonly TotallyLegitHoroscopesContext context;
        public GenericRepository(TotallyLegitHoroscopesContext context)
        {
            this.context = context;
        }

        public async Task<bool> Add(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            T entity = await Get(id);
            context.Set<T>().Remove(entity);
            return true;
        }

        public async Task<T> Get(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<bool> Update(T entity)
        {
            context.Set<T>().Update(entity);
            return true;
        }

        public async void Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
