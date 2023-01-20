using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project.ViewComponents.Dashboard
{
    public class StatisticsDashboard : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {

            ViewBag.v1 = context.Portfolios.Count();
            ViewBag.v2 = context.Services.Count();
            ViewBag.v3 = context.Messages.Count();

            // var values = contactManager.TGetList();
            return View();
        }
    }
}
