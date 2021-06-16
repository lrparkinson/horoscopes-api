using System.ComponentModel.DataAnnotations;

namespace totally_legit_horoscopes_api.Models
{
    public class AbstractNoun
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public bool IsPositive { get; set; }
    }
}
