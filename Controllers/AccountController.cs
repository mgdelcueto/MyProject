using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Data.SqlClient;

namespace MyProject.Controllers {
    public class AccountController : Controller {
        private readonly MyProjectDBContext _dbContext;
        public AccountController(MyProjectDBContext dbContext) {
            _dbContext = dbContext;
        }
        public int _year ;
        [HttpGet]
        public IActionResult ListCont()  {
            ViewData["Title"] = "Indicar el año para las cuentas anuales";
            return View("ListCont");      
        }
        [HttpPost]
        public IActionResult ListCont(int year) {
            return RedirectToAction("LstCnt",new{@year=year});
        }
        public IActionResult LstCnt(int year) {
            string syear =year.ToString();
            ViewData["Title"] = "Relación de Gastos anuales "+syear;
            var dbContext = new MyProjectDBContext();
            
            try{
            //var model = _dbContext.PAccView.Where(AccView => AccView.AccYear ==year).OrderBy(AccView => AccView.AccOrder).ToList();
            var model = _dbContext.TAccount.Where(TAccount => TAccount.AccYear ==year).OrderBy(TAccount => TAccount).ToList();
            return View("Index",model);
            }
            catch{
                return View("Error");}
            
        }        
        [HttpGet]
        public IActionResult Yearly() {
            return View();      
        }
        [HttpPost]
        public IActionResult Yearly(string year) {
            //string year ="2020";
            ViewData["Title"] = "All Items";
            try{
             //var model = _dbContext.PAccView.Where(AccView => AccView.AccYear ==2020).OrderBy(AccView => AccView.AccOrder).ToList();
             var model = _dbContext.Account.FromSqlRaw("exec newYear @year ", new SqlParameter("year",year)).ToList<Account>();
             var nothing = _dbContext.PAccView.FromSqlRaw("exec PAccView @year ", new SqlParameter("year",year)).ToList<PAccView>();
             return View("YearlyDone");
            }
            catch{
                return View("Error");}
            
        }
                [HttpGet]
        public IActionResult Repport() {
            return View();      
        }
        [HttpPost]
        public IActionResult Repport(string year) {
            //string year ="2020";
            ViewData["Title"] = "Expenses report";
            try{
             //var model = _dbContext.PAccView.Where(AccView => AccView.AccYear ==2020).OrderBy(AccView => AccView.AccOrder).ToList();
             var model = _dbContext.Repport.FromSqlRaw("exec Repport @year ", new SqlParameter("year",year)).ToList<Repport>().First();
             return View("RepportL",model);
            }
            catch{
                return View("Error");}
            
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
            var model = _dbContext.TAccount
                .SingleOrDefault(u => u.AccId.Equals(id));
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult Edit(TAccount product) {
            int year=product.AccYear;
            if (ModelState.IsValid)
            try{
                _dbContext.TAccount.Update(product);
                _dbContext.SaveChanges();
                var model = _dbContext.TAccount.FromSqlRaw("exec TUpdate @year ", new SqlParameter("year",year)).ToList<TAccount>().First();

            }
            catch{}
            return RedirectToAction("LstCnt",new{@year=year});
        }     
          
    }
}