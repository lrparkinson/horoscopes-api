using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
namespace totally_legit_horoscopes_api.DataAccess
{
    public class UserRepository:GenericRepository<User>, IUserRepository
    {
        public UserRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }

        public async Task<User> GetByEmail(string Email)
        {
            return await context.Users.SingleAsync(x => x.Email.Equals(Email));
        }

        public async Task<User> Get(int id)
        {
            User entity = await context.Users.Include(e => e.Profession).Include(e => e.FavoriteDinosaur).Include(e => e.Hobbies).Include(e => e.StarSign).Include(e => e.LifeNumber).SingleAsync(x => x.UserId == id);
            return entity;
        }

        new public async Task<bool> Update( User user)
        {
            context.Dinosaurs.Attach(user.FavoriteDinosaur);
            context.StarSigns.Attach(user.StarSign);
            context.Professions.Attach(user.Profession);
            foreach (Hobby hobby in user.Hobbies)
            {
                context.Attach(hobby);
            }
            context.Set<User>().Update(user);
            context.SaveChanges();
            return true;
        }

        
    }
}
