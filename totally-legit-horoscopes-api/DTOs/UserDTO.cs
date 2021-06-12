﻿using System;
using System.Collections.Generic;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DTOs
{
    public class UserDTO
    {
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public int NthChild { get; set; }
        public ProfessionDTO Profession { get; set; }
        public StarSignDTO StarSign { get; set; }
        public Dinosaur FavoriteDinosaur { get; set; }
        public List<HobbyDTO> Hobbies { get; set; }
    }
}
