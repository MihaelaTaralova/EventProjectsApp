﻿using System.ComponentModel.DataAnnotations;

namespace EventProject.Application.DTO.Login_Register
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; }

        [UIHint("hidden")]
        public string? ReturnUrl { get; set; }
    }
}
