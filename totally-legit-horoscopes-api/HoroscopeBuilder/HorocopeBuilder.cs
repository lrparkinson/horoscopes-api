using System;
using System.Collections.Generic;
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
        protected List<string> positiveNounBaseList = new List<string>() { "joy", "excitement", "freedom", "surprises" };
        protected List<string> negativeNounBaseList = new List<string>() { "sorrow", "discontentment", "spiders", "impatience" };
        protected User user;
        protected Horoscope horoscope;

        private string template = "Today is a good day for {star_sign}, {ruling_planet} is in " +
        "approaching an auspicious house of the night sky. As a result {occupation} " +
        "such as you can look forward to a day filled with {positive_abstract_noun} " +
        "but be wary of {negative_abstract_noun} which might turn this day from a win " +
        "into a terrible loss";

        private string template2 = "{star_sign} beware! {ruling_planet} is in retrograde. " +
        "Change isn't always a bad thing, but just in case, connect with your element {star_sign_element}. " +
        "Turn to {hobby} when things get overwhelming or hug a {favourite_dinosaur} stuffie.";

        public HoroscopeBuilder()
        {
            random = new Random();
            user = new User();
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

        public void PopulateRandomWords()
        {
            // read from DB

            int randomIndex = random.Next(positiveNounBaseList.Count);
            this.horoscope.Reading = this.horoscope.Reading.Replace(positiveNounKey, positiveNounBaseList[randomIndex]);
            randomIndex = random.Next(negativeNounBaseList.Count);
            this.horoscope.Reading = this.horoscope.Reading.Replace(negativeNounKey, negativeNounBaseList[randomIndex]);
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
