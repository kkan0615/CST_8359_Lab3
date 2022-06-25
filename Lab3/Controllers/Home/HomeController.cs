using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            System.Diagnostics.Debug.WriteLine(Request.Form["numberOfBottles"]);
            HttpContext.Session.SetString("numberOfBottles", Request.Form["numberOfBottles"]);

            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            return View(person);

        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
