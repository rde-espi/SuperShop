﻿using System.ComponentModel.DataAnnotations;

namespace SuperShop.Web.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name ="Current Password")]
        public string OldPassword { get; set; }

        [Required]
        [Display(Name = "Current Password")]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }
}