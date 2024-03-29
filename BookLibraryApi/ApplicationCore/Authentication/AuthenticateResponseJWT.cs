﻿using ApplicationCore.Entities;
using ApplicationCore.Enums;

namespace ApplicationCore.Authentication
{
    public class AuthenticateResponseJWT
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? Username { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        public AuthenticateResponseJWT(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            Username = user.Username;
            Role = user.Role;
            Token = token;
        }
    }
}
