﻿using System.ComponentModel.DataAnnotations;

namespace PatikaIdentityDataProtection.Dto
{
    public class UserRegisterDto
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }
    }
}