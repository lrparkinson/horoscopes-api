using System;
using System.Collections.Generic;
using System.Linq;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.HoroscopeBuilder
{
    public abstract class HoroscopeBuilder
    {
        protected Random random;

        //TODO: consider storing keys in DB?
        protected Dictionary<string, string> knownDataKeyDictionary;

        protected const string positiveNounKey = "{positive_abstract_noun}";
        protected const string negativeNounKey = "{negative_abstract_noun}";
        protected User user;
        protected Horoscope horoscope;
        protected HoroscopeTemplateRepository horoscopeTemplateRepository;
        protected PositiveAbstractNounRepository positiveNounRepository;
        protected NegativeAbstractNounRepository negativeNounRepository;


        public HoroscopeBuilder(
            HoroscopeTemplateRepository horoscopeTemplateRepository,
            PositiveAbstractNounRepository positiveAbstractNounRepository,
            NegativeAbstractNounRepository negativeAbstractNounRepository)
        {
            random = new Random();
            user = new User();
            this.horoscopeTemplateRepository = horoscopeTemplateRepository;
            this.positiveNounRepository = positiveAbstractNounRepository;
            this.negativeNounRepository = negativeAbstractNounRepository;
        }

        public abstract Horoscope CreateHoroscopeBase();

        public Horoscope GetHoroscope()
        {
            return horoscope;
        }

        public abstract void SetCategory();

        //public abstract void PopulateUserInfo();
        //public abstract void PopulateRandomWords();

        public void PopulateUserInfo()
        {
            foreach (KeyValuePair<string, string> keyValuePair in knownDataKeyDictionary)
            {
                horoscope.Reading = horoscope.Reading.Replace(keyValuePair.Key, keyValuePair.Value);
            }
        }

        public async void PopulateRandomWords()
        {
            var positiveNounList = (await positiveNounRepository.GetAll()).ToList();
            int randomIndex = random.Next(positiveNounList.Count());
            this.horoscope.Reading = this.horoscope.Reading.Replace(positiveNounKey, positiveNounList[randomIndex].ToString());

            var negativeNounList = (await negativeNounRepository.GetAll()).ToList();
            randomIndex = random.Next(negativeNounList.Count);
            this.horoscope.Reading = this.horoscope.Reading.Replace(negativeNounKey, negativeNounList[randomIndex].ToString());
        }

        protected void SetupKnownDataDictionary()
        {
            //pull from DB
            knownDataKeyDictionary = new Dictionary<string, string>()
                                        {
                                            { "{star_sign}", user.StarSign.Name },
                                            { "{occupation}", user.Profession.Name },
                                            { "{ruling_planet}", user.StarSign.RulingPlanet },
                                            { "{hobby}", (user.Hobbies.Count > 0 ? user.Hobbies[0].Name : "Doing Nothing") },
                                            { "{favourite_dinosaur}", user.FavoriteDinosaur.Name },
                                            { "{star_sign_element}", user.StarSign.Element }
                                        };
        }

    }
}
