using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.DataAccess;
using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Services;

namespace totally_legit_horoscopes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoroscopeController : ControllerBase
    {
        private readonly IHoroscopeServices _horoscopeService;
        private readonly IUserRepository _userRepository;
        private readonly int userId = 1;

        public HoroscopeController(
            IHoroscopeServices horoscopeService,
            IUserRepository userRepository)
        {
            _horoscopeService = horoscopeService;
            _userRepository = userRepository;
        }

        // GET: api/Hobbies
        [HttpPost("GeneralHoroscope")]
        public async Task<ActionResult<Horoscope>> CreateGeneralHoroscope()
        {
            User user = await _userRepository.Get(userId);
            if (user == null)
            {
                return NotFound(user);
            }

            Horoscope horoscope = await _horoscopeService.CreateGeneralHoroscope(user);

            return CreatedAtAction("CreateGeneralHoroscope", horoscope);
        }

        [HttpPost("LoveHoroscope")]
        public async Task<ActionResult<Horoscope>> CreateLoveHoroscope()
        {
            User user = await _userRepository.Get(userId);
            if (user == null)
            {
                return NotFound(user);
            }

            Horoscope horoscope = await _horoscopeService.CreateLoveHoroscope(user);

            return CreatedAtAction("CreateLoveHoroscope", horoscope);
        }

        [HttpPost("CareerHoroscope")]
        public async Task<ActionResult<Horoscope>> CreateCareerHoroscope()
        {
            User user = await _userRepository.Get(userId);
            if (user == null)
            {
                return NotFound(user);
            }

            Horoscope horoscope = await _horoscopeService.CreateCareerHoroscope(user);

            return CreatedAtAction("CreateCareerHoroscope", horoscope);
        }

        [HttpGet("Horoscopes")]
        public async Task<ActionResult<IEnumerable<Horoscope>>> GetPastHoroscopes()
        {
            User user = await _userRepository.Get(userId);

            if (user == null)
            {
                return NotFound(user);
            }

            return Ok(await _horoscopeService.GetPastHoroscopes(userId));
        }
    }

}
