using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Message
{
    public class MessageList : ViewComponent
    {

        MessageManager userMessageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {

            var values = userMessageManager.TGetList();
            return View(values);
        }
    }
}
