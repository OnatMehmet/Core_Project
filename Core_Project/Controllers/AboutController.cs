using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımda ";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda";
            var values = aboutManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditAbout()
        {
            ViewBag.v1 = "Hakkımda";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda";

            return View();
        }
        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            aboutManager.TAdd(about);
            return RedirectToAction("Index");
        }
    }
}
