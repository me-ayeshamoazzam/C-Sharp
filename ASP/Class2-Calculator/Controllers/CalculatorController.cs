using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class2_Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int num1, int num2, string operation)
        {
            int result = 0;

            switch (operation)
            {
            case "Add":
                result = num1 + num2;
                break;
            case "Subtract":    
                result = num1 - num2;
                break;
            case "Multiply":
                result = num1 * num2;
                break;
            case "Divide":
                result = num1 / num2;
                break;
            }
            ViewBag.data = result;
            return View();
        }
    }
}