using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using totally_legit_horoscopes_api.Contexts;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.Models;
using System;
using totally_legit_horoscopes_api.DataAccess;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IStarSignRepository _starSignRepository;
        private readonly IHoroscopeRepository _horoscopeRepository;

        private readonly ILifeNumberRepository _lifeNumberRepository;

        public UsersController(
            IUserRepository userRepository,
            IStarSignRepository starSignRepository,
            IHoroscopeRepository horoscopeRepository,
            ILifeNumberRepository _lifeNumberRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _starSignRepository = starSignRepository;
            _horoscopeRepository = horoscopeRepository;

        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            return Ok((await _userRepository.GetAll()).Select(user => _mapper.Map<UserDTO>(user)));
        }


        // GET: api/Users/1
        [HttpGet("{1}")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUserByID(int ID)
        {
            User user = await _userRepository.Get(ID);
            return Ok(_mapper.Map<UserDTO>(user));
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<UserDTO>>> CreateUser(UserDTO user)
        {
            List<Hobby> mappedHobbies = user.Hobbies.Select(hobby => _mapper.Map<Hobby>(hobby)).ToList();
            Profession mappedProfession = _mapper.Map<Profession>(user.Profession);
            LifeNumber LifeNumber = await _lifeNumberRepository.Get(calculateLifeNumber(user.DateOfBirth));
            // TODO: create lifenumber model/table with meanings for each lifenumber
            // see https://www.numerology.com/articles/your-numerology-chart/life-path-number/
            StarSign starSign = await getStarSignOfDate(user.DateOfBirth);
            User dbUser = new User(user.Email, user.DateOfBirth, user.NthChild, mappedProfession, starSign, user.FavoriteDinosaur, mappedHobbies, LifeNumber);

            await _userRepository.Add(dbUser);
            _userRepository.Save();

            return CreatedAtAction("CreateUser", new { id = dbUser.UserId }, user);
        }

        private bool dateInStarSign(DateTime date, StarSign starSign)
        {
            if (date.DayOfYear >= starSign.StartDate.DayOfYear && date.DayOfYear <= starSign.EndDate.DayOfYear)
            {
                return true;
            }

            return false;
        }

        private async Task<StarSign> getStarSignOfDate(DateTime date)
        {
            var StarSigns = await _starSignRepository.GetAll();
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


