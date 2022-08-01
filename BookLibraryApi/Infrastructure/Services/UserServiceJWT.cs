using ApplicationCore.Authentication;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserServiceJWT : IUserServiceJWT
    {
        private readonly BookLibraryContext context;
        private readonly ITokenServiceJWT tokenService;

        public UserServiceJWT(BookLibraryContext context, ITokenServiceJWT tokenService)
        {
            this.context = context;
            this.tokenService = tokenService;
        }

        public async Task<AuthenticateResponseJWT> Authenticate(AuthenticateRequestJWT authenticateRequest)
        {
            var user = await Task.Run(() => context.Set<User>().SingleOrDefault(x => x.Username == authenticateRequest.Username));

            if (user is null || !BCrypt.Net.BCrypt.Verify(authenticateRequest.Password, user.PasswordCrypted))
            {
                throw new ApplicationException("Invalid user");
            }

            // generate token
            var token = tokenService.GenerateToken(user);

            return new AuthenticateResponseJWT(user, token);
        }

        public async Task<User> GetById(int id)
        {
            var user = await context.Set<User>().FindAsync(new object[] { id });

            if (user is null)
            {
                throw new AccessViolationException("Invalid user");
            }

            return user;
        }
    }
}
