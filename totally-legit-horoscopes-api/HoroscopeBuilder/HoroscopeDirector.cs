using System.Threading.Tasks;
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

        public async Task<Horoscope> ConstructFullHoroscope()
        {
            await this.horoscopeBuilder.CreateHoroscopeBase();
            this.horoscopeBuilder.PopulateUserInfo();
            await this.horoscopeBuilder.PopulateRandomWords();
            await this.horoscopeBuilder.SprinkleInMoreCustomDetails();
            return this.GetHoroscope();
        }

        public Horoscope GetHoroscope()
        {
            return this.horoscopeBuilder.GetHoroscope();
        }
    }
}
