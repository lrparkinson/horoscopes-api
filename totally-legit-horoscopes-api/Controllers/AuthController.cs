using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using totally_legit_horoscopes_api.Services;
using totally_legit_horoscopes_api.Models;
using totally_legit_horoscopes_api.Helpers;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.DataAccess;
using Google.Apis.Auth;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Cryptography;

namespace totally_legit_horoscopes_api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost("Google")]
        public AuthenticationDTO Google([FromBody] UserView userView)
        {
            AuthenticationDTO authenticationDTO = new AuthenticationDTO();
            User user = null;
            try
            {
                var payload = GoogleJsonWebSignature.ValidateAsync(userView.tokenId, new GoogleJsonWebSignature.ValidationSettings()).Result;
                Task<User> userTask = _userRepository.GetByEmail("omwwer@bbd.co.za");
                user = userTask.Result;
                authenticationDTO.RegisteredUser = true;
            }
            catch (Exception ex)
            {
                authenticationDTO.RegisteredUser = false;
            }

            authenticationDTO.Token = Security.GetHashString(userView.tokenId);

            return authenticationDTO;
        }
    }
}
