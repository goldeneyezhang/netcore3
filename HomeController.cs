
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication
{
    public class HomeController:Controller
    {
        [HttpGetAttribute("/{name}")]
        public IActionResult Index(string name)
        {
           ViewBag.Name=name;
           return View();
        }
    }
}