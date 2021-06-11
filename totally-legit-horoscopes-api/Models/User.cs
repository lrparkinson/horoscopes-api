using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
