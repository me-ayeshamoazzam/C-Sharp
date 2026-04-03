using Microsoft.AspNetCore.Mvc;

namespace Class3_HtmlTemplate.Controllers
{
    public class tempController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
