using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    /// <summary>
    /// Referanslar
    /// </summary>
    public class TestimonialController : Controller 
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
             ViewBag.r2 = "Testimonial";
            ViewBag.v1 = "Referanslar Listesi";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar Listesi";
            var values = testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            ViewBag.v1 = "Yeni Referans Ekleme";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Yeni Referans Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }
    }
}
