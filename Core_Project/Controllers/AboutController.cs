using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımda Düzenleme ";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenleme ";

            var values = aboutManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index( About about)
        {
            ViewBag.v1 = "Hakkımda Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenleme";
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
     
    }
}
