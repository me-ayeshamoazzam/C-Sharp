using Microsoft.AspNetCore.Mvc;

namespace Class4_Viewbag.Controllers
{
    public class ViewbagController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "This message is from Viewbag";
            ViewBag.CurrentDate = DateTime.Now.ToString();
            string[] fruits = { "Apple" , "Mango", "Banana" };
            ViewBag.FruitsArray = fruits;

            return View();
        }
    }
}
