using System.ComponentModel.DataAnnotations;

namespace totally_legit_horoscopes_api.Models
{
    public class LifeNumber
    {
        [Key]
        public int LifeNumberInt { get; set; }
        public string Description { get; set; }
    }
}
