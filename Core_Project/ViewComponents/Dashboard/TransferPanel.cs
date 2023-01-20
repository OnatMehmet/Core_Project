using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class TransferPanel : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
