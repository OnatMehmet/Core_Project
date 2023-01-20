using Core_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
   
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userLogin.UserName, userLogin.Password, true, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Writer");

                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı Adı veya Parola Hatalı");
                }
            }

            return View();

        }

        public IActionResult Logout()
        {
           // return View();
            return RedirectToAction("Login","Writer");
        }
    }
}
