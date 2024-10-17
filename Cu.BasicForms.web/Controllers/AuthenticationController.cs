using Microsoft.AspNetCore.Mvc;

namespace Cu.BasicForms.web.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
