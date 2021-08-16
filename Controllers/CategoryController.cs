using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Data.Models;

namespace CoreAndFood.Controllers
{  
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();     
        public IActionResult Index(string par)
        {
            if (!string.IsNullOrEmpty(par))
            {
                return View(categoryRepository.List(x => x.CategoryName == par));
            }
            return View(categoryRepository.TList());
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category par)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(par);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var x = categoryRepository.TGet(id);
            Category cat = new Category()
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription
            };
            return View(cat);         
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category par)
        {
            var x = categoryRepository.TGet(par.CategoryID);
            x.CategoryName = par.CategoryName;
            x.CategoryDescription = par.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {          
            categoryRepository.TDelete(new Category { CategoryID = id});
            return RedirectToAction("Index");
        }

        public IActionResult CategoryChange(int id)
        {
            var x = categoryRepository.TGet(id);
            x.Status = false;
            categoryRepository.TUpdate(x);        
            return RedirectToAction("Index");
        }

    }
}