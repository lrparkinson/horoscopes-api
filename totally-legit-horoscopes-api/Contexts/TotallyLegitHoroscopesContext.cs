using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Contexts
{
    public class TotallyLegitHoroscopesContext : DbContext
    {
        public TotallyLegitHoroscopesContext(DbContextOptions<TotallyLegitHoroscopesContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne("LifeNumber");
            modelBuilder.Entity<User>()
                .HasOne("Profession");
            modelBuilder.Entity<User>()
                .HasOne("StarSign");
            modelBuilder.Entity<User>()
                .HasMany(e => e.Hobbies)
                .WithMany(e => e.User);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StarSign> StarSigns { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Horoscope> Horoscopes { get; set; }
        public DbSet<AbstractNoun> AbstractNouns { get; set; }
        public DbSet<Dinosaur> Dinosaurs { get; set; }
        public DbSet<HoroscopeReadingTemplate> HoroscopeReadingTemplates { get; set; }
        public DbSet<HoroscopeReadingTemplateCategory> HoroscopeReadingTemplateCategories { get; set; }
        public DbSet<StarRatingCategory> StarRatingCategories { get; set; }
    }
}
