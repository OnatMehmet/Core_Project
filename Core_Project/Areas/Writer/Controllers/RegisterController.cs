using Core_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Project.Areas.Writer.Controllers
{

    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegister)//pass=Mo.123456
        {
            if (ModelState.IsValid)
            {
                WriterUser w = new WriterUser()
                {
                    FirstName = userRegister.FirstName,
                    LastName = userRegister.LastName,
                    UserName = userRegister.UserName,
                    Email = userRegister.Mail,
                    ImageUrl = userRegister.ImageUrl
                };

                if (userRegister.Password == userRegister.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(w, userRegister.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Writer");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }

                    }
                }


            }

            return View();
        }
    }
}
