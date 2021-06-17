using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Services
{
    public interface IAuthService
    {
        Task<User> Authenticate(Google.Apis.Auth.GoogleJsonWebSignature.Payload payload);
    }

    public class AuthService : IAuthService
    {
        public AuthService()
        {
            this.Refresh();
        }
        private static IList<User> _users = new List<User>();
        public async Task<User> Authenticate(Google.Apis.Auth.GoogleJsonWebSignature.Payload payload)
        {
            await Task.Delay(1);
            return this.FindUserOrAdd(payload);
        }

        private User FindUserOrAdd(Google.Apis.Auth.GoogleJsonWebSignature.Payload payload)
        {
            var u = _users.Where(x => x.Email == payload.Email).FirstOrDefault();
            if (u == null)
            {
                u = new User();
                u.Email = payload.Email;
                u.OAuthSubject = payload.Subject;
                u.OAuthIssuer = payload.Issuer;
                _users.Add(u);
            }
            this.PrintUsers();
            return u;
        }

        private void PrintUsers()
        {
            string s = String.Empty;
            foreach (var u in _users) s += "\n[" + u.Email + "]";
            //Helpers.SimpleLogger.Log(s);
        }

        private void Refresh()
        {
            if (_users.Count == 0)
            {
                _users.Add(new User() { Email = "arealemail@gmail.com" });
                _users.Add(new User() { Email = "anotherpersonsemail@gmail.com" });
                _users.Add(new User() { Email = "thirdpersonsemail@gmail.com" });
                this.PrintUsers();
            }
        }
    }
}
