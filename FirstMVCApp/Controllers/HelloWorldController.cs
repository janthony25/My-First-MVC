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

        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View("Index");
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
