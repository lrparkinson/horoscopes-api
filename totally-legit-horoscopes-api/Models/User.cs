using System;
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
        public DateTime Dob { get; set; }
        [Required]
        public int NthChild { get; set; }
        [Required]
        public Profession Profession { get; set; }
        [Required]
        public StarSign StarSign { get; set; }

    }
}
