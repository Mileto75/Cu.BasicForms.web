using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Cu.BasicForms.web.ViewModels
{
    public class AuthenticationRegisterViewModel 
    {
        [Required]
        [Display(Name = "Username")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Repeat your password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        //dropdown list of provinces
        [Display(Name = "Province")]
        public int ProvinceId { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }
    }
}
