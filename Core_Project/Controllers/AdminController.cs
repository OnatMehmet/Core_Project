using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Default";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "Default ";
            return View();
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

    }
}
