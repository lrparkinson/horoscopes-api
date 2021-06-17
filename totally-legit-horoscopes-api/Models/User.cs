﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace totally_legit_horoscopes_api.Models
{
    public class User
    {
        public User(){}
        public User(string Email, DateTime DateOfBirth, int NthChild, Profession Profession, StarSign StarSign, Dinosaur FavoriteDinosaur, List<Hobby> Hobbies, int LifeNumber)  
        {
            this.Email = Email;
            this.Dob = DateOfBirth;
            this.NthChild = NthChild;
            this.FavoriteDinosaur = FavoriteDinosaur;
            this.Profession = Profession;
            this.StarSign = StarSign;
            this.Hobbies = Hobbies;
            this.LifeNumber = LifeNumber;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; private set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
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
        public int LifeNumber { get; set; }

    }
}
