using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            CatViewModel catt = new CatViewModel()
            { CatName = "Moe", CatAge = 8 };
            return View(catt);
        }
    }
}
