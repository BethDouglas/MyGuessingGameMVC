using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyGuessingGame.Models
{
    public class Game
    {
        [Required]
        [MaxLength(25, ErrorMessage = "Name must be 25 characters or less")]
        [Display(Name = "Your Name")]
        public string GuesserName { get; set; }

        [Range(1,100, ErrorMessage = "Please choose a number between 1 and 10.")]
        public int Guess { get; set; }
    }
}