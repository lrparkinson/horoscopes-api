using System;

namespace totally_legit_horoscopes_api.DTOs
{
    public class StarSignDTO
    {
        public string Name { get; set; }
        public string RulingPlanet { get; set; }
        public string Element { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
