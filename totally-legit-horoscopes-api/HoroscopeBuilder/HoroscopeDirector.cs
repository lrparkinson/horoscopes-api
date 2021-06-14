using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public class HoroscopeDirector
    {
        private HoroscopeBuilder horoscopeBuilder;

        public HoroscopeDirector(HoroscopeBuilder horoscopeBuilder)
        {
            this.horoscopeBuilder = horoscopeBuilder;
        }

        public void ConstructFullHoroscope()
        {
            this.horoscopeBuilder.CreateHoroscopeBase();
            this.horoscopeBuilder.PopulateUserInfo();
            this.horoscopeBuilder.PopulateRandomWords();
        }

        public Horoscope GetHoroscope()
        {
            return this.horoscopeBuilder.GetHoroscope();
        }
    }
}
