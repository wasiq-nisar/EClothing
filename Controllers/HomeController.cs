using EClothing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EClothing.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(){
            return View();
        }
    }
}