using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Linq;

namespace MyProject.Controllers {
    public class PeriodsController : Controller {
        private readonly MyProjectDBContext _dbContext;
        public PeriodsController(MyProjectDBContext dbContext) {
            _dbContext = dbContext;
        }
        public IActionResult Index() {
            ViewData["Title"] = "All Periods";
            var dbContext = new MyProjectDBContext();
            try{
             var model = _dbContext.Periods.OrderBy(Periods => Periods.PerNum).ToList();
             return View(model);
            }
            catch{return View("Error");}
            
        }
  
    }
}