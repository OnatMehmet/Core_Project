using Core_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel model = new UserEditViewModel();
            model.FirstName = values.FirstName;
            model.LastName = values.LastName;
            model.PictureUrl = values.ImageUrl;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEdit)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(userEdit.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEdit.Picture.FileName);
                var imageName = Guid.NewGuid()+ extension;
                var saveLocation = resource + "/wwwroot/userimage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userEdit.Picture.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            user.FirstName = userEdit.FirstName;
            user.LastName = userEdit.LastName;
            user.PasswordHash = userEdit.Password;

            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");

            }
            else
            {
            return View();
            }

            
        }


    }
}
