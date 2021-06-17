using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    public interface IHoroscopeTemplateRepository:IGenericRepository<HoroscopeReadingTemplate>
    {
        public HoroscopeReadingTemplate GetGeneralHoroscope();
        public HoroscopeReadingTemplate GetLoveHoroscope();
        public HoroscopeReadingTemplate GetCareerHoroscope();
    }
}
