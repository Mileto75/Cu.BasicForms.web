using Cu.BasicForms.web.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
