using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.r2 = "Service";

            ViewBag.v1 = "Hizmetler Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Listesi";
            var values = serviceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Yeni Hizmet Ekleme";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Yeni Hizmet Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {

            ViewBag.v1 = "Hizmet Düzenleme";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Düzenleme";

            var service = serviceManager.TGetByID(id);
            return View(service);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {

            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }



        public IActionResult DeleteService(int id)
        {

            var service = serviceManager.TGetByID(id);
            serviceManager.TDelete(service);
            return RedirectToAction("Index");
        }
    }
}
