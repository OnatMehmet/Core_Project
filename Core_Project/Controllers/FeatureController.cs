using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{/// <summary>
/// Öne Çıkanlar
/// </summary>
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.v1 = "Öne Çıkanlar";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkan Listesi";

            var feature = featureManager.TGetByID(1);
            return View(feature);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {

            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }

    }
}
