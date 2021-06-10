using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.Models
{
    public class Horoscope
    {
        [Key]
        public long HoroscopeId {get;set;}
        [Required]
        public string Reading { get; set; }
        [Required]
        public DateTime ReadingDate { get; set; }
        [Required]
        public User User { get; set; }
    }
}
