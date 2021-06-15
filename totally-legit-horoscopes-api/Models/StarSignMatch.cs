using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.Models
{
    public class StarSignMatch
    {
        public StarSignMatch(StarSign mainStarSign)
        {
            this.MainStarSign = mainStarSign;
        }

        public StarSign MainStarSign { get; set; }
        public StarSign LoveMatch { get; set; }
        public StarSign CareerMatch { get; set; }
        public StarSign FriendshipMatch { get; set; }
    }
}
