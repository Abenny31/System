using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace CorePokus3.ViewModels
{
    [Keyless]
    public class RegisterViewModel
    {
        [Display(Name = "First Name")]
        //[Required(ErrorMessage = "Firstname should be more than 2 characters")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        // [Required(ErrorMessage = "Lastname should be more than 4 characters")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "PIN i")]
        public int PIN { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Email Address")]
        // [Required(ErrorMessage = "Email address is invalid")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Employee")]
        public bool IsEmployee { get; set; }

        [Display(Name = "Volunteer")]
        public bool IsVolunteer { get; set; }

        [Display(Name = "Out")]
        public bool IsOutsorced { get; set; }
        [Display(Name = "Username")]
        // [Required(ErrorMessage = "username ")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Login { get; set; }
        [Display(Name = "Password")]
        //  [Required(ErrorMessage = "Password should be more than 8 characters")]
        //[MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
