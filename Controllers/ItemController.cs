using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Linq;

namespace MyProject.Controllers {
    public class ItemController : Controller {
        private readonly MyProjectDBContext _dbContext;
        public ItemController(MyProjectDBContext dbContext) {
            _dbContext = dbContext;
        }
        public IActionResult Index() {
            ViewData["Title"] = "All Items";
            var dbContext = new MyProjectDBContext();
            try{
             var model = _dbContext.ItemView.OrderBy(ItemView => ItemView.ItemOrder).ToList();
             return View(model);
            }
            catch{return View("Error");}
            
        }
        public IActionResult ShowDetail(int id) {
            var model = _dbContext.Items
                .SingleOrDefault(u => u.ItemId.Equals(id));
            if (model != null)
                return View("Detail", model);
            else
                return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create() {
            return View();      
        }

        [HttpPost]
        public IActionResult Create(Item product) {
            if (ModelState.IsValid)
            try{
                _dbContext.Items.Add(product); 
                _dbContext.SaveChanges();
                }
            catch{}
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) {
            var model = _dbContext.Items
                .SingleOrDefault(u => u.ItemId.Equals(id));
            try{
            _dbContext.Items.Remove(model);
            _dbContext.SaveChanges();
            }  
            catch{}          
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id) {
            try{
            var model = _dbContext.Items
                .SingleOrDefault(u => u.ItemId.Equals(id));
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult Edit(Item product) {
            if (ModelState.IsValid)
            try{
                _dbContext.Items.Update(product);
                _dbContext.SaveChanges();
            }
            catch{}
            return RedirectToAction("Index");
        }     
          
    }
}