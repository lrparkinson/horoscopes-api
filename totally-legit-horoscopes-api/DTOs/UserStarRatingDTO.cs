namespace totally_legit_horoscopes_api.DTOs
{
    public class UserStarRatingDTO
    {
        public System.DateTime CreatedDate { get; set; }
        public StarRatingCategoriesDTO StarRatingCategory { get; set; }
        public int Rating { get; set; }
    }
}
