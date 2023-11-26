using System.ComponentModel.DataAnnotations;

namespace TEJADA_ITELEC1.ViewModel

{

    public class RegisterViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username Required")]
        public string? Username { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Required")]
        public string? Password { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please confirm your password")]

        public string? ConfirmPassword { get; set; }

        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Display(Name = "LastName")]
        public string? LastName { get; set; }

        [Display(Name = "EmailAddress")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email address required")]
        public string? EmailAddress { get; set; }

        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "you must follow the format 000-000-0000")]
        [Display(Name = "PhoneNumber")]
        public string? PhoneNumber { get; set; }

    }
}
