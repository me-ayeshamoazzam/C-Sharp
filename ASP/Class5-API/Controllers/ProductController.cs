using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
0


namespace Class5_API.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public JsonResult GetProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name= "Gaming PC", Price= 12855.50m, Quantity = 14, IsAvailable = true },
                new Product { Id = 2, Name= "Samsung Phone", Price= 100000.30m, Quantity = 20, IsAvailable = true },
                new Product { Id = 3, Name= "iPad", Price= 12000.20m, Quantity = 0, IsAvailable = false },
                new Product { Id = 4, Name= "HP Laptop", Price= 1000.10m, Quantity = 30, IsAvailable = true },
                new Product { Id = 6, Name= "Dell Laptop", Price= 30000.10m, Quantity = 50, IsAvailable = true },
                new Product { Id = 7, Name= "Apple Watch", Price= 50000.10m, Quantity = 20, IsAvailable = true },
                new Product { Id = 8, Name= "LED Light", Price= 2000, Quantity = 00, IsAvailable = false },
                new Product { Id = 9, Name= "Headphones", Price= 3000.10m, Quantity = 80, IsAvailable = true },
                new Product { Id = 10, Name= "MIC", Price= 30000.10m, Quantity = 20, IsAvailable = true },
                new Product { Id = 11, Name= "Keyboard", Price= 40000.10m, Quantity = 50, IsAvailable = true },
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}