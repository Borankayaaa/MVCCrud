using MVCCrud.DesignPatterns.SingletonPattern;
using MVCCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.Controllers
{
    public class CategoryController : Controller
    {
        NORTHWNDEntities _db;

        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }
        public ActionResult ListCategories()
        {
            return View(_db.Categories.ToList());
        }


        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category) 
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("ListCategories");
        }
    }
}