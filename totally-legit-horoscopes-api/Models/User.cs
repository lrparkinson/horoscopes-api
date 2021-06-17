using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace totally_legit_horoscopes_api.Models
{
    public class User
    {
        [Key]
        public long UserId { get; private set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public int NthChild { get; set; }
        public Profession Profession { get; set; }
        public StarSign StarSign { get; set; }
        public Dinosaur FavoriteDinosaur { get; set; }
        public List<Hobby> Hobbies { get; set; }
        [Required]
        public bool Deleted { get; set; }
    }
}
