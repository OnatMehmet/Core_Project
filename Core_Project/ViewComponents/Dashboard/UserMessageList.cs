using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project.ViewComponents.Dashboard
{
    public class UserMessageList: ViewComponent
    {
        
        UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            //ViewBag.v1 = context.Skills.Count();
            //ViewBag.v2 = context.Messages.Where(x => x.Status == false).Count();
            //ViewBag.v3 = context.Messages.Where(x => x.Status == true).Count();
            //ViewBag.v4 = context.Experiences.Count();

             var values = userMessageManager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
