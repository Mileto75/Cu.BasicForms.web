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
            //validate the data
            //check the modelstate
            if (!ModelState.IsValid)
            {
                //validation errors found!
                return View(authenticationLoginViewModel);
            }
            //process the form
            //check credentials
            if(authenticationLoginViewModel.Username.Equals("mil@mil.com")
                && authenticationLoginViewModel.Password.Equals("Test123?"))
            {
                //and redirect 
                return RedirectToAction("Index", "home");
            }
            //wrong credentials!
            //add custom error
            ModelState.AddModelError("", "Wrong credentials!");
            return View(authenticationLoginViewModel);
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
            //validate the data
            //check the modelstate
            if(!ModelState.IsValid)
            {
                //validation errors found!
                return View(authenticationRegisterViewModel);
            }
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
