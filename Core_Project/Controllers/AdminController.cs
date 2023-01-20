using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Admin";
            ViewBag.v2 = "Admin";
            ViewBag.v3 = "Admin ";
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
