using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
           
            ViewBag.v1 = "Beceri Listesi";
            ViewBag.v2 = "Beceriler";
            ViewBag.r2 = "Skill";
            ViewBag.v3 = "Beceri Listesi";
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {  
            ViewBag.v1 = "Yeni Beceri Ekleme";
            ViewBag.v2 = "Beceriler";
            ViewBag.v3 = "Yeni Beceri Ekleme";
           
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
          
            ViewBag.v1 = "Beceri Düzenleme";
            ViewBag.v2 = "Beceriler";
            ViewBag.v3 = "Beceri Düzenleme";

            var skill = skillManager.TGetByID(id);
            return View(skill);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }



        public IActionResult DeleteSkill(int id)
        {
            
            var skill= skillManager.TGetByID(id);
            skillManager.TDelete(skill);
            return RedirectToAction("Index");
        }

       
    }
}
