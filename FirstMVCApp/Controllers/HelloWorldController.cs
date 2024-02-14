using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name= "Hatsu", Age=3};
            return View(doggo);
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
