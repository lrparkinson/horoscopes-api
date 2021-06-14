﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.Models;
using System;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly TotallyLegitHoroscopesContext _context;
        private readonly IMapper _mapper;

        public UsersController(TotallyLegitHoroscopesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            return await _context.Users.Select(user => _mapper.Map<UserDTO>(user)).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<UserDTO>>> CreateUser(UserDTO user)
        {
            List<Hobby> mappedHobbies = user.Hobbies.Select(hobby => _mapper.Map<Hobby>(hobby)).ToList();
            Profession mappedProfession = _mapper.Map<Profession>(user.Profession);
            int LifeNumber = calculateLifeNumber(user.Dob);
            // TODO: create lifenumber model/table with meanings for each lifenumber
            // see https://www.numerology.com/articles/your-numerology-chart/life-path-number/
            
            User dbUser = new User(user.Email, "password", user.Dob, user.NthChild, mappedProfession, getStarSignOfDate(user.Dob), user.FavoriteDinosaur, mappedHobbies);

            _context.Users.Add(dbUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("CreateUser", new { id = dbUser.UserId }, user);
        }

        private bool dateInStarSign(DateTime date, StarSign starSign)
        {
            if (date.DayOfYear >= starSign.StartDate.DayOfYear && date.DayOfYear <= starSign.StartDate.DayOfYear)
            {
                return true;
            }

            return false;
        }

        private StarSign getStarSignOfDate(DateTime date)
        {
            var StarSigns = _context.StarSigns;
            foreach (StarSign starSign in StarSigns)
            {
                if (dateInStarSign(date, starSign))
                {
                    return starSign;
                }
            }

            throw new InvalidOperationException("Date is not contained in any star sign");
        }

        private int calculateLifeNumber(DateTime dateOfBirth)
        {
            int year = dateOfBirth.Year;
            int month = dateOfBirth.Month;
            int day = dateOfBirth.Day;

            int reducedYear = reduceInt(year);
            int reducedMonth = reduceInt(month);
            int reducedDay = reduceInt(day);

            int lifeNumber = reduceInt(reducedYear + reducedMonth + reducedDay);

            return lifeNumber;
        }

        private int reduceInt(int value)
        {
            if (value == 11 || value == 22) //Master numbers
            {
                return value;
            }

            string stringRepresentation = value.ToString();
            int result = 0;
            foreach (char digit in stringRepresentation)
            {
                result += int.Parse(digit.ToString());
            }
            return result;
        }
    }
}


