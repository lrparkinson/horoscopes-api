using System.ComponentModel.DataAnnotations;
using totally_legit_horoscopes_api.Constants.Enums;

namespace totally_legit_horoscopes_api.Models
{
    public class AbstractNoun
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Value { get; set; }
        public Connotation Connotation { get; set; }
    }
}
