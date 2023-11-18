using System.ComponentModel.DataAnnotations;


namespace TEJADA_ITELEC1.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "A username is required")]
        public string? UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "A password is required")]
        public string? Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }

    }
}
