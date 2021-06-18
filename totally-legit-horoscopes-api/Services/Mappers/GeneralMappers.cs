using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.Services.Mappers
{
    public class GeneralMappers
    {
        public static string CardinalToOrndinal(int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }
    }
}
