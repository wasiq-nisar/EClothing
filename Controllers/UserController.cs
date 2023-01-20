using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EClothing.Controllers
{
    public class UserController : Controller
    {
        public ViewResult LoginSignup()
        {
            return View();
        }

        [HttpPost]
        public void SignUp(string name,string email, string password, string confirmPassword) {

            Console.WriteLine($"Name: {name} , Email: {email} , Password: {password}");
            //return View();
        }

        public void Signin(string email, string password) {
            Console.WriteLine($"Email: {email} , Password: {password}");
            //return View();
        }
    }
}
