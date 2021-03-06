﻿using System.ComponentModel.DataAnnotations;

namespace Shop.Northwind.MvcWebUI
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match! Please check again.")]
        public string ConfirmPassword { get; set; }
    }
}