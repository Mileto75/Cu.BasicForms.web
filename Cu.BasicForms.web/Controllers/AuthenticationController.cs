using Cu.BasicForms.web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cu.BasicForms.web.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            //show the login form
            return View();
        }
        [HttpPost]
        public IActionResult Login(AuthenticationLoginViewModel authenticationLoginViewModel)
        {
            //process the form
            //redirect to homepage
            return RedirectToAction("Index","home");
        }
        [HttpGet]
        public IActionResult Register() 
        {
            //show the form
            //create a viewmodel
            //create a list of provinces
            var authenticationRegisterViewModel
                = new AuthenticationRegisterViewModel();
            authenticationRegisterViewModel
                .Provinces = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Please select a province",Value = "0",Disabled = true, Selected = true },
                    new SelectListItem {Text = "West-Vlaanderen",Value = "1", },
                    new SelectListItem {Text = "Oost-Vlaanderen",Value = "2" },
                    new SelectListItem {Text = "Limburg", Value = "3" },
                    new SelectListItem {Text = "Henegouwen", Value = "4" },
                };
            return View(authenticationRegisterViewModel);
        }
        [HttpPost]
        public IActionResult Register(AuthenticationRegisterViewModel 
            authenticationRegisterViewModel)
        {
            //process the form
            //and redirect 
            return RedirectToAction("Registered","Authentication");
        }
        [HttpGet]
        public IActionResult Registered()
        {
            return View();
        }
    }
}
