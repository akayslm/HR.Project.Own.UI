using Microsoft.AspNetCore.Mvc;

namespace HR.Project.Own.UI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
