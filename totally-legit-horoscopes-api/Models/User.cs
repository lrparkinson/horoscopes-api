using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace totally_legit_horoscopes_api.Models
{
    public class User
    {
        public User(){}
        public User(string Email,  string Password, DateTime Dob, int NthChild, Profession Profession, StarSign StarSign, Dinosaur FavoriteDinosaur, List<Hobby> Hobbies)  
        {
            this.Email = Email;
            this.Password = Password;
            this.Dob = Dob;
            this.NthChild = NthChild;
            this.FavoriteDinosaur = FavoriteDinosaur;
            this.Profession = Profession;
            this.StarSign = StarSign;
            this.Hobbies = Hobbies;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; private set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public int NthChild { get; set; }
        [Required]
        public Profession Profession { get; set; }
        [Required]
        public StarSign StarSign { get; set; }
        public Dinosaur FavoriteDinosaur { get; set; }
        public List<Hobby> Hobbies { get; set; }

    }
}
