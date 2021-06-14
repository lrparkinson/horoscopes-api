using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace totally_legit_horoscopes_api.Models
{
    public class StarRatingCategories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<UserStarRatings> Users { get; set; }


    }
}
