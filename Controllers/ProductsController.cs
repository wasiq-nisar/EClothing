using Microsoft.AspNetCore.Mvc;

namespace EClothing.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
