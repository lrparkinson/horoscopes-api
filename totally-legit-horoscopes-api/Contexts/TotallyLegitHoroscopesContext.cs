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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StarSign>().HasData(GetStarSigns());
            modelBuilder.Entity<Profession>().HasData(GetProfessions());
            modelBuilder.Entity<Hobby>().HasData(GetHobbies());
            modelBuilder.Entity<PositiveAbstractNoun>().HasData(GetPositiveAbstractNouns());
            modelBuilder.Entity<NegativeAbstractNoun>().HasData(GetNegativeAbstractNouns());
            modelBuilder.Entity<Dinosaur>().HasData(GetDinosaurs());
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
                new StarSign { Name = "Aquarius", RulingPlanet = "Uranus", Element = "Air", StartDate = new DateTime(1, 1, 20), EndDate = new DateTime(1, 2, 18) },
                new StarSign { Name = "Pisces", RulingPlanet = "Neptune", Element = "Water", StartDate = new DateTime(1, 2, 19), EndDate = new DateTime(1, 3, 20) },
                new StarSign { Name = "Aries", RulingPlanet = "Mars", Element = "Fire", StartDate = new DateTime(1, 3, 21), EndDate = new DateTime(1, 4, 19) },
                new StarSign { Name = "Taurus", RulingPlanet = "Venus", Element = "Earth", StartDate = new DateTime(1, 4, 20), EndDate = new DateTime(1, 5, 20) },
                new StarSign { Name = "Gemini", RulingPlanet = "Mercury", Element = "Air", StartDate = new DateTime(1, 5, 21), EndDate = new DateTime(1, 6, 20) },
                new StarSign { Name = "Cancer", RulingPlanet = "The Moon", Element = "Water", StartDate = new DateTime(1, 6, 21), EndDate = new DateTime(1, 7, 22) },
                new StarSign { Name = "Leo", RulingPlanet = "The Sun", Element = "Fire", StartDate = new DateTime(1, 7, 23), EndDate = new DateTime(1, 8, 22) },
                new StarSign { Name = "Virgo", RulingPlanet = "Mercury", Element = "Earth", StartDate = new DateTime(1, 8, 23), EndDate = new DateTime(1, 9, 22) },
                new StarSign { Name = "Libra", RulingPlanet = "Venus", Element = "Air", StartDate = new DateTime(1, 9, 23), EndDate = new DateTime(1, 10, 22) },
                new StarSign { Name = "Scorpius", RulingPlanet = "Pluto", Element = "Water", StartDate = new DateTime(1, 10, 23), EndDate = new DateTime(1, 11, 21) },
                new StarSign { Name = "Sagiattarius", RulingPlanet = "Jupiter", Element = "Fire", StartDate = new DateTime(1, 11, 22), EndDate = new DateTime(1, 12, 21) },
                new StarSign { Name = "Capricornus", RulingPlanet = "Saturn", Element = "Earth", StartDate = new DateTime(1, 12, 22), EndDate = new DateTime(1, 1, 19) }
            };
        }
        private List<Hobby> GetHobbies() {
            string[] lines = File.ReadAllLines(@".\Resources\hobbies.txt");
            List<Hobby> hobbies = lines.Select(hobby => new Hobby { Name = hobby }).ToList();
            return hobbies;
        }
        private List<PositiveAbstractNoun> GetPositiveAbstractNouns() {
            string[] lines = File.ReadAllLines(@".\Resources\positive_abstract_nouns.txt");
            List<PositiveAbstractNoun> positiveAbstractNouns = lines.Select(noun => new PositiveAbstractNoun { Value = noun }).ToList();
            return positiveAbstractNouns;
        }   
        private List<NegativeAbstractNoun> GetNegativeAbstractNouns()
        {
            string[] lines = File.ReadAllLines(@".\Resources\negative_abstract_nouns.txt");
            List<NegativeAbstractNoun> negativeAbstractNouns = lines.Select(noun => new NegativeAbstractNoun { Value = noun }).ToList();
            return negativeAbstractNouns;
        }
        private List<Dinosaur> GetDinosaurs()
        {
            string[] dinos = File.ReadAllLines(@".\Resources\dinosaurs.txt");
            List<Dinosaur> dinosaurs = dinos.Select(dino => new Dinosaur { Name = dino }).ToList();
            return dinosaurs;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StarSign> StarSigns { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Horoscope> Horoscopes { get; set; }
        public DbSet<PositiveAbstractNoun> PositiveAbstractNouns { get; set; }
        public DbSet<NegativeAbstractNoun> NegativeAbstractNouns { get; set; }
        public DbSet<Dinosaur> Dinosaurs { get; set; }
    }
}
