using System.ComponentModel.DataAnnotations;

namespace Cu.BasicForms.web.ViewModels
{
    public class AuthenticationLoginViewModel
    {
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please provide a valid email!")]
        [MaxLength(50,ErrorMessage = "Email too long!")]
        [Required(ErrorMessage = "Please provide a email!")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please provide a password!")]
        [MaxLength(15,ErrorMessage = "Password too long!")]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
