using HR.Project.Own.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HR.Project.Own.UI.Controllers
{
    public class SpendingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SpendingRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SpendingRequest(Spending spending)
        {
            return View();
        }
        
        public IActionResult SpendingList()
        {
            return View();
        }

        
    }
}
