using System.ComponentModel.DataAnnotations;

namespace totally_legit_horoscopes_api.Models
{
    public class HoroscopeReadingTemplate
    {
        [Key]
        public long TemplateId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Template { get; set; }
    }
}
