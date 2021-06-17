using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace totally_legit_horoscopes_api.Models
{
    public class User
    {
        public User() { }
        public User(string Email)
        {
            this.Email = Email;
        }
        public void updateUser(string Email, DateTime DateOfBirth, int NthChild, Profession Profession, StarSign StarSign, Dinosaur FavoriteDinosaur, List<Hobby> Hobbies, LifeNumber LifeNumber)
        {
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.NthChild = NthChild;
            this.FavoriteDinosaur = FavoriteDinosaur;
            this.Profession = Profession;
            this.StarSign = StarSign;
            this.Hobbies = Hobbies;
            this.LifeNumber = LifeNumber;
        }
        [Key]
        public int UserId { get; private set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int NthChild { get; set; }
        public Profession Profession { get; set; }
        public StarSign StarSign { get; set; }
        public Dinosaur FavoriteDinosaur { get; set; }
        public List<Hobby> Hobbies { get; set; }
        public LifeNumber LifeNumber { get; set; }

        [Required]
        public bool Deleted { get; set; }
    }
}
