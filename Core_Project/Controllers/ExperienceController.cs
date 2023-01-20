using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    /// <summary>
    /// Beceriler
    /// </summary>
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.r2 = "Experience";
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Yeni Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Yeni Deneyim Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {

            ViewBag.v1 = "Deneyim Düzenleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Düzenleme";

            var experience = experienceManager.TGetByID(id);
            return View(experience);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {

            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }



        public IActionResult DeleteExperience(int id)
        {

            var experience = experienceManager.TGetByID(id);
            experienceManager.TDelete(experience);
            return RedirectToAction("Index");
        }
    }
}
