﻿using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Contexts;

namespace totally_legit_horoscopes_api.DataAccess
{
    public class DinosaurRepository : GenericRepository<Dinosaur>, IDinosaurRepository
    {
        public DinosaurRepository(TotallyLegitHoroscopesContext context) : base(context)
        {

        }
    }
}
