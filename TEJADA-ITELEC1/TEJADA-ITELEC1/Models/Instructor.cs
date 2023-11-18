using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TEJADA_ITELEC1.Models
{
    public enum Rank
    {
       Instructor, AssociateProfessor, AssistantProfessor, Professor
    }

    public class Instructor
    {
        [Required]
        public int Id { get; set; }


        [Display (Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "isTenured")]
        public bool isTenured { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "HiringDate")]
        public DateTime HiringDate { get; set; }

        [Required]
        [Display(Name = "Rank")]
        public Rank Rank { get; set; }

            [RegularExpression("[0-9][3] - [0-9][3] - [0-9][4]]", ErrorMessage = "you must follow the format 000-000-0000")]
            [Display (Name = "Office phone number")]
            public string? PhoneNumber { get; set; }


        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        [Url]
        [Display(Name = "Personal Webpage")]
        public string? PersonalURL { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Password (We won't use this!)")]
        [DataType(DataType.Password)]
        public string? UnusedPassword { get; set; }


    }
}
