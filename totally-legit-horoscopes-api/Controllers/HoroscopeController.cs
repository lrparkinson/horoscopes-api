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
        private readonly int userId = 3;

        public HoroscopeController(
            IHoroscopeServices horoscopeService,
            IUserRepository userRepository)
        {
            _horoscopeService = horoscopeService;
            _userRepository = userRepository;
        }

        // GET: api/Hobbies
        [HttpGet("GeneralHoroscope")]
        public async Task<ActionResult<Horoscope>> CreateOrGetGeneralHoroscope()
        {
            User user = await _userRepository.GetUserWithFKS(userId);
            if (user == null)
            {
                return NotFound(user);
            }

            Horoscope horoscope = await _horoscopeService.CreateOrGetGeneralHoroscope(user);

            return Ok(horoscope);
        }

        [HttpGet("LoveHoroscope")]
        public async Task<ActionResult<Horoscope>> CreateOrGetLoveHoroscope()
        {
            User user = await _userRepository.GetUserWithFKS(userId);
            if (user == null)
            {
                return NotFound(user);
            }

            Horoscope horoscope = await _horoscopeService.CreateOrGetLoveHoroscope(user);

            return Ok(horoscope);
        }

        [HttpGet("CareerHoroscope")]
        public async Task<ActionResult<Horoscope>> CreateOrGetCareerHoroscope()
        {
            User user = await _userRepository.GetUserWithFKS(userId);
            if (user == null)
            {
                return NotFound(user);
            }

            Horoscope horoscope = await _horoscopeService.CreateOrGetCareerHoroscope(user);

            return Ok(horoscope);
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
