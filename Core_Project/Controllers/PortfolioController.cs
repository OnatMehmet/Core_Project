using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    /// <summary>
    /// Projeler
    /// </summary>
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Projeler Listesi";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Projeler Listesi";
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Yeni Proje Ekleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Yeni Proje Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Yeni Proje Ekleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Yeni Proje Ekleme";
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);

            if (result.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }


        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {

            ViewBag.v1 = "Proje Düzenleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Yeni Proje Düzenleme";

            var portfolio = portfolioManager.TGetByID(id);
            return View(portfolio);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Proje Düzenleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Yeni Proje Düzenleme";

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);

            if (result.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(portfolio);


        }



        public IActionResult DeletePortfolio(int id)
        {

            var portfolio = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(portfolio);
            return RedirectToAction("Index");
        }
    }
}
