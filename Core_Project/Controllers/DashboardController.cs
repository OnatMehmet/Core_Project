using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class DashboardController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            ViewBag.t1 = "Etkinlik Silindi";
            ViewBag.t2 = "";
            ViewBag.v1 = "İstatistik Listesi";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "İstatistik Listesi";
            return View();
        }

        public IActionResult RemoveToDoList(int id)
        {
            
            var todolist = c.ToDoLists.Find(id);
            todolist.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
