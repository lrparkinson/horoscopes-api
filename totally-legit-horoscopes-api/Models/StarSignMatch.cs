using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace totally_legit_horoscopes_api.Models
{
    public class StarSignMatch
    {
        [Key]
        public long Id { get; private set; }
        [Required]
        public DateTime DateMatched { get; set; }
        [Required]
        public StarSign MainStarSign { get; set; }
        public StarSign LoveMatch { get; set; }
        public StarSign CareerMatch { get; set; }
        public StarSign FriendshipMatch { get; set; }
    }
}
