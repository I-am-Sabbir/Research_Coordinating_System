﻿using Membership.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Identities.Models
{
    public class RegistrartionModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistrartionModel()
        {
        }

        public RegistrartionModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //public async Task RegistrationAsync()
        //{
        //    var user = new ApplicationUser
        //    {
        //        UserName = this.UserName,
        //        PhoneNumber =this.PhoneNumber,
        //        Email = this.Email
        //    };
        //     await _userManager.CreateAsync(user);
        //}
    }
}
