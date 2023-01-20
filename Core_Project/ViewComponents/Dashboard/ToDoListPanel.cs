using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project.ViewComponents.Dashboard
{
    public class ToDoListPanel :ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());

        public IViewComponentResult Invoke()
        {
            var getList = toDoListManager.TGetList();
            getList = getList.Where(x=>x.Status==true).ToList();
            return View(getList);
        }
    }
}
