using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AccountController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            userManager.TAdd(user);
            return View("Login");
        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
