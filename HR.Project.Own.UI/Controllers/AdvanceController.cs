using HR.Project.Own.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HR.Project.Own.UI.Controllers
{
    public class AdvanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AvansTalepEt()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AvansTalepEt(Advance advance)
        {
            return View(advance);
        }

        public IActionResult AvansListele()
        {
            return View();
        }
    }
}
