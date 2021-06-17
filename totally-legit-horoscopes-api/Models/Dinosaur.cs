using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace totally_legit_horoscopes_api.Models
{
    public class Dinosaur
    {
        [Key]
        public string Name { get; set; }

        // public virtual ICollection<User> User { get; set; }
    }
}
