using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class7_Validation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(string username, string age, string email)
        {
            if(string.IsNullOrWhiteSpace(username))
            {
                ModelState.AddModelError("username", "Username is required");
            }
            if(string.IsNullOrWhiteSpace(age))
            {
                ModelState.AddModelError("age", "Age is required");
            }
            if(string.IsNullOrWhiteSpace(email))
            {
                ModelState.AddModelError("email", "Email is required");
            }
            if(ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script> alert('Form Submitted') </script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}