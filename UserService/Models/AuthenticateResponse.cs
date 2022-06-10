﻿using System.ComponentModel.DataAnnotations;
using UserService.entities;

namespace UserService.Models
{
    public class AuthenticateResponse
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(UserProfile user, string token)
        {
            Id = user.Id;
            Name = user.Name;
            EmailId = user.EmailId;
            Token = token;
        }
    }
}
