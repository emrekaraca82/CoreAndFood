using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;
using System.IO;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context c = new Context();

        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index(int page=1)
        {        
            return View(foodRepository.TList("Category").ToPagedList(page,10));
        }

        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> values = (from x in c.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public IActionResult FoodAdd(productAdd par)
        {
            Food f = new Food();
            if (par.ImageUrl !=null)
            {
                var extension = Path.GetExtension(par.ImageUrl.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/resimler/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                par.ImageUrl.CopyTo(stream);
                f.ImageUrl=newimagename;
            }

            f.Name = par.Name;
            f.Description = par.Description;
            f.Price = par.Price;
            f.Stock = par.Stock;
            f.CategoryID = par.CategoryID;

            foodRepository.TAdd(f);
            return RedirectToAction("Index");
        }

        public IActionResult FoodDelete(int id)
        {
            foodRepository.TDelete(new Food { FoodID = id });
            return RedirectToAction("Index");
        }

     
        public IActionResult FoodGet(int id)
        {
            var x = foodRepository.TGet(id);

            List<SelectListItem> values = (from y in c.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;

            Food fod = new Food()
            {
                FoodID = x.FoodID,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                Stock = x.Stock,
                ImageUrl = x.ImageUrl
            };
            return View(fod);
        }

        [HttpPost]
        public IActionResult FoodUpdate(Food par)
        {
            var x = foodRepository.TGet(par.FoodID);
            x.Name = par.Name;
            x.CategoryID = par.CategoryID;
            x.Description = par.Description;
            x.Price = par.Price;
            x.Stock = par.Stock;
            x.ImageUrl = par.ImageUrl;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
        }


    }
}