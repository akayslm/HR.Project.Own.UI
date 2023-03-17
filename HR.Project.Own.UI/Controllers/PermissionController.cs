using Microsoft.AspNetCore.Mvc;

namespace HR.Project.Own.UI.Controllers
{
    public class PermissionController : Controller
    {
        public IActionResult PermissionRequest()
        {
            return View();
        }
        
        public IActionResult PermissionList()
        {
            return View();
        }
    }
}
