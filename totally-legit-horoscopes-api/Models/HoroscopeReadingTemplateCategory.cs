using System.ComponentModel.DataAnnotations;

namespace totally_legit_horoscopes_api.Models
{
    public class HoroscopeReadingTemplateCategory
    {
        [Key]
        public string Name { get; set; }
    }
}
