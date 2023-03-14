using HR.Project.Own.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HR.Project.Own.UI.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bilgilerim()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BilgilerimiGuncelle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BilgilerimiGuncelle(User user)
        {
            return View();
        }
    }
}
