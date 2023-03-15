using HR.Project.Own.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HR.Project.Own.UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }


    }
}
