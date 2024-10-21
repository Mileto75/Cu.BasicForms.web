using System.ComponentModel.DataAnnotations;

namespace Cu.BasicForms.web.ViewModels
{
    public class AuthenticationLoginViewModel
    {
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
