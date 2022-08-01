using ApplicationCore.Entities;
using ApplicationCore.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Authorization
{
    public class AuthorizeJWTAttribute : Attribute, IAuthorizationFilter
    {
        private readonly Role[] roles;

        public AuthorizeJWTAttribute(params Role[] roles)
        {
            this.roles = roles ?? Array.Empty<Role>();
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var anonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (anonymous)
            {
                return;
            }

            var user = (User?)context.HttpContext.Items["User"];
            if (user is null || (roles.Any() && !roles.Contains(user.Role)))
            {
                context.Result = new JsonResult(new { Status = "You are not authorized!" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
