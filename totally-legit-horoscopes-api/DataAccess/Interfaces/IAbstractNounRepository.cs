﻿using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    interface IAbstractNounRepository:IGenericRepository<AbstractNoun>
    {
        public Task<AbstractNoun> GetRandomAbstractNoun(bool shouldGetPositiveNoun);
    }
}
