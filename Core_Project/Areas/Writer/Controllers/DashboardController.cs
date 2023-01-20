using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = values.FirstName + " " + values.LastName;

        //istatistikler


       

            string api = "0bd0f0498f3208f15c5b93f9e3ceb889";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid="+api;

            XDocument document = XDocument.Load(connection);
            ViewBag.Api = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            Context context = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = context.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = context.Skills.Count();
            return View();
        }
    }
}
