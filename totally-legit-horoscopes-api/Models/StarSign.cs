using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace totally_legit_horoscopes_api.Models
{
    public class StarSign
    {
        [Key]
        public string Name { get; set;}
        [Required]
        public string RulingPlanet { get; set; }
        [Required] 
        public string Element { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
