using ApplicationCore.Interfaces;

namespace BookLibraryApi.TokenCheckMiddleware
{
    public class TokenCheckMiddleware : IMiddleware
    {
        private readonly ITokenServiceJWT tokenService;
        private readonly IUserServiceJWT userService;

        public TokenCheckMiddleware(ITokenServiceJWT tokenService, IUserServiceJWT userService)
        {
            this.tokenService = tokenService;
            this.userService = userService;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = tokenService.ValidateToken(token);
            if (userId is not null)
            {
                context.Items["User"] = await userService.GetById(userId.Value);
            }

            await next(context);
        }
    }
}
