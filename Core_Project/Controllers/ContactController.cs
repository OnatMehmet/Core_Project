using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "İletişim Listesi";
            ViewBag.v2 = "İletişim";
            ViewBag.v3 = "İletişim Listesi";
            var values = contactManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Yeni İletişim Ekleme";
            ViewBag.v2 = "İletişim";
            ViewBag.v3 = "Yeni İletişim Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Contact contact)
        {
            contactManager.TAdd(contact);
            return RedirectToAction("Index");
        }
    }
}
