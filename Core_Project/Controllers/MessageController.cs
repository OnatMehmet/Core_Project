using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Mesaj Listesi";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Mesaj Listesi";
            var values = messageManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Yeni Mesaj Ekleme";
            ViewBag.v2 = "Mesaj";
            ViewBag.v3 = "Yeni Mesaj Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Message message)
        {
            messageManager.TAdd(message);
            return RedirectToAction("Index");
        }
    }
}
