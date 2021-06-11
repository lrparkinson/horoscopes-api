using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Contexts
{
    public class TotallyLegitHoroscopesContext: DbContext
    {
        public TotallyLegitHoroscopesContext(DbContextOptions<TotallyLegitHoroscopesContext> options): base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<StarSign> StarSigns { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Horoscope> Horoscopes { get; set; }
        public DbSet<PositiveAbstractNoun> PositiveAbstractNouns { get; set; }
        public DbSet<NegativeAbstractNoun> NegativeAbstractNouns { get; set; }
        public DbSet<Dinosaur> Dinosaurs { get; set; }
        public DbSet<HoroscopeReadingTemplate> HoroscopeReadingTemplates { get; set; }
    }
}
