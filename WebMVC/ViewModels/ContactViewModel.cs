﻿using System.ComponentModel.DataAnnotations;

namespace WebMVC.ViewModels
{
	public class ContactViewModel
	{
        [Required(ErrorMessage = "Please enter your name")]
        [MinLength(2, ErrorMessage = "Name has to be at minumun 2 characters"]

        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Please enter you comment below")]
        public string Comment { get; set; } = null!;

        public bool IsSent { get; set; } = false;
    }
}
