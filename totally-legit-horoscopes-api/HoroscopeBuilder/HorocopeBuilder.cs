using System;
using System.Collections.Generic;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public abstract class HoroscopeBuilder
    {
        protected Dictionary<string, string> knownDataKeyDictionary;
        protected const string positiveNounKey = "{positive_abstract_noun}";
        protected const string negativeNounKey = "{negative_abstract_noun}";
        protected User user;
        protected Horoscope horoscope;
        protected IHoroscopeTemplateRepository horoscopeTemplateRepository;
        protected IAbstractNounRepository abstractNounRepository;


        public HoroscopeBuilder(
            User user,
            IHoroscopeTemplateRepository horoscopeTemplateRepository,
            IAbstractNounRepository abstractNounRepository)
        {
            this.user = user;
            this.horoscopeTemplateRepository = horoscopeTemplateRepository;
            this.abstractNounRepository = abstractNounRepository;
        }

        public Horoscope CreateHoroscopeBase()
        {
            SetupKnownDataDictionary();
            horoscope = new Horoscope();
            horoscope.ReadingDate = DateTime.Now;
            horoscope.User = this.user;
            HoroscopeReadingTemplate horoscopeReadingTemplate = GetHoroscopeTemplate();
            horoscope.Category = horoscopeReadingTemplate.Category;
            horoscope.Reading = horoscopeReadingTemplate.Template;
            return horoscope;
        }

        public abstract HoroscopeReadingTemplate GetHoroscopeTemplate();

        public Horoscope GetHoroscope()
        {
            return horoscope;
        }

        public void PopulateUserInfo()
        {
            foreach (KeyValuePair<string, string> keyValuePair in knownDataKeyDictionary)
            {
                horoscope.Reading = horoscope.Reading.Replace(keyValuePair.Key, keyValuePair.Value);
            }
        }

        public async virtual void PopulateRandomWords()
        {
            if (this.horoscope.Reading.Contains(positiveNounKey) || this.horoscope.Reading.Contains(negativeNounKey))
            {
                string postiveAbstractNoun = (await abstractNounRepository.GetRandomAbstractNoun(true)).Value.ToLower();
                string negativeAbstractNoun = (await abstractNounRepository.GetRandomAbstractNoun(false)).Value.ToLower();
                this.horoscope.Reading = this.horoscope.Reading.Replace(positiveNounKey, postiveAbstractNoun);
                this.horoscope.Reading = this.horoscope.Reading.Replace(negativeNounKey, negativeAbstractNoun);
            }
        }

        protected void SetupKnownDataDictionary()
        {
            knownDataKeyDictionary = new Dictionary<string, string>()
                                        {
                                            //{ "{star_sign}", user.StarSign.Name },
                                            //{ "{occupation}", user.Profession.Name },
                                            //{ "{ruling_planet}", user.StarSign.RulingPlanet },
                                            //{ "{hobby}", (user.Hobbies.Count > 0 ? user.Hobbies[0].Name : "Doing Nothing") },
                                            //{ "{favourite_dinosaur}", user.FavoriteDinosaur.Name },
                                            //{ "{star_sign_element}", user.StarSign.Element }
                                        };
        }

    }
}
