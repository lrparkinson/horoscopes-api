using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.DTOs
{
    public class StarSignMatchDTO
    {
        public DateTime DateMatched { get; set; }
        public StarSignDTO MainStarSign { get; set; }
        public StarSignDTO LoveMatch { get; set; }
        public StarSignDTO CareerMatch { get; set; }
        public StarSignDTO FriendshipMatch { get; set; }
    }
}
