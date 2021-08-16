using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }

        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            using (var c = new Context())
            {
                cs = c.foods.Select(x => new Class1
                {
                    foodname = x.Name,
                    price = x.Price                 
                }).ToList();
            }
            return cs;
        }

        public IActionResult Statistics()
        {
            Context c = new Context();
            var deger1 = c.foods.Count();
            ViewBag.d1 = deger1;

            var deger2 = c.categories.Count();
            ViewBag.d2 = deger2;


            var deger3 = c.foods.Where(x=>x.CategoryID== c.categories.Where(z=>z.CategoryName == "Fruit").Select(y=>y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d3 = deger3;

            var deger4 = c.foods.Where(x => x.CategoryID == c.categories.Where(z => z.CategoryName == "Vegatables").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d4 = deger4;

            var deger5 = c.foods.Where(x => x.CategoryID == c.categories.Where(z => z.CategoryName == "Legumes").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d5 = deger5;

            var deger6 = c.foods.Sum(x=>x.Price);
            ViewBag.d6 = deger6;

            var deger7 = c.foods.OrderByDescending(x => x.Stock).Select(y=>y.Name).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = c.foods.OrderBy(x => x.Stock).Select(y => y.Name)
                .FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = c.categories.Where(x => x.CategoryName == "Legumes").Select(y => y.CategoryID).FirstOrDefault();
            var deger9c = c.foods.Where(y => y.CategoryID == deger9).Sum(x => x.Price);
            ViewBag.d9 = deger9c;

            var deger10 = c.categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
            var deger10c = c.foods.Where(y => y.CategoryID == deger10).Sum(x => x.Price);
            ViewBag.d10 = deger10c;

            var deger11 = c.categories.Where(x => x.CategoryName == "Vegatables").Select(y => y.CategoryID).FirstOrDefault();
            var deger11c = c.foods.Where(y => y.CategoryID == deger11).Sum(x => x.Price);
            ViewBag.d11 = deger11c;

            var deger12 = c.foods.OrderByDescending(x => x.Price).Select(y => y.Name).FirstOrDefault();
            ViewBag.d12 = deger12;

            return View();
        }
    }
}