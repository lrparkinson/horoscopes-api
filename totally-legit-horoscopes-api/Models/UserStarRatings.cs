using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace totally_legit_horoscopes_api.Models
{
    public class UserStarRatings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }
        public System.DateTime CreatedDate { get; set; }
        public User User { get; set; }
        public StarRatingCategories StarRatingCategory { get; set; }
        public int Rating { get; set; }


        public UserStarRatings()
        {
            CreatedDate = System.DateTime.UtcNow;
        }

        public UserStarRatings(User User, StarRatingCategories StarRatingCategory, int Rating) : this()
        {
            this.User = User;
            this.StarRatingCategory = StarRatingCategory;
            this.Rating = Rating;
        }

    }
}
