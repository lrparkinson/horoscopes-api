﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;
using System.Linq;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionsController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;
        private readonly IProfessionRepository professionRepository;
        //private readonly IAbstractNounRepository abstractNounRepository;

        public ProfessionsController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            professionRepository = new ProfessionRepository(_context);
            //abstractNounRepository = new AbstractNounRepository(_context);
        }

        // GET: api/Professions
        [HttpGet]
        public async Task<IEnumerable<ProfessionDTO>> GetProfessions()
        {
            IEnumerable<Profession> professions = await professionRepository.GetAll();
            return professions.Select(profession => _mapper.Map<ProfessionDTO>(profession));
        }

        //// GET: api/Professions
        //[HttpGet("/negative")]
        //public async Task<AbstractNoun> GetNegative()
        //{
        //    return await abstractNounRepository.GetRandomAbstractNoun(false);
        //}

        //// GET: api/Professions
        //[HttpGet("/positive")]
        //public async Task<AbstractNoun>GetPositive()
        //{
        //    return await abstractNounRepository.GetRandomAbstractNoun(true);
        //}

    }
}
