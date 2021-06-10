﻿using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StarSign>().HasData(GetStarSigns());
            modelBuilder.Entity<Profession>().HasData(GetProfessions());
            modelBuilder.Entity<Hobby>().HasData(GetHobbies());
        }

        private List<Profession> GetProfessions()
        {
            string[] occupations = File.ReadAllLines(@".\Resources\occupations.txt");
            List<Profession> professions = occupations.Select( occupation => new Profession { Name = occupation }).ToList();
            return professions;
        }
        private List<StarSign> GetStarSigns()
        {
            return new List<StarSign>
            {
                new StarSign { Name = "Aquarius", StartDate = new DateTime(1, 1, 20), EndDate = new DateTime(1, 2, 18) },
                new StarSign { Name = "Pisces", StartDate = new DateTime(1, 2, 19), EndDate = new DateTime(1, 3, 20) },
                new StarSign { Name = "Aries", StartDate = new DateTime(1, 3, 21), EndDate = new DateTime(1, 4, 19) },
                new StarSign { Name = "Taurus", StartDate = new DateTime(1, 4, 20), EndDate = new DateTime(1, 5, 20) },
                new StarSign { Name = "Gemini", StartDate = new DateTime(1, 5, 21), EndDate = new DateTime(1, 6, 21) },
                new StarSign { Name = "Cancer", StartDate = new DateTime(1, 6, 22), EndDate = new DateTime(1, 7, 22) },
                new StarSign { Name = "Leo", StartDate = new DateTime(1, 7, 23), EndDate = new DateTime(1, 8, 22) },
                new StarSign { Name = "Virgo", StartDate = new DateTime(1, 8, 23), EndDate = new DateTime(1, 9, 22) },
                new StarSign { Name = "Libra", StartDate = new DateTime(1, 9, 23), EndDate = new DateTime(1, 10, 23) },
                new StarSign { Name = "Scorpius", StartDate = new DateTime(1, 10, 24), EndDate = new DateTime(1, 11, 21) },
                new StarSign { Name = "Sagiattarius", StartDate = new DateTime(1, 11, 22), EndDate = new DateTime(1, 12, 21) },
                new StarSign { Name = "Capricornus", StartDate = new DateTime(1, 12, 22), EndDate = new DateTime(1, 1, 19) }
            };
        }
        private List<Hobby> GetHobbies() {
            string[] lines = File.ReadAllLines(@".\Resources\hobbies.txt");
            List<Hobby> hobbies = lines.Select(hobby => new Hobby { Name = hobby }).ToList();
            return hobbies;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StarSign> StarSigns { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Horoscope> Horoscopes { get; set; }
    }
}
