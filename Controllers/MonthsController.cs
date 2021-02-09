using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Linq;

namespace MyPproject.Controllers {
    public class MonthsController : Controller {
        private readonly MyProjectDBContext _dbContext;
        public MonthsController(MyProjectDBContext dbContext) {
            _dbContext = dbContext;
        }
        public IActionResult Index() {
            ViewData["Title"] = "All Months";
            var dbContext = new MyProjectDBContext();
            try{
             var model = _dbContext.Months.OrderBy(Months => Months.MoNum).ToList();
             return View(model);
            }
            catch{return View("Error");}
        }
    }
}