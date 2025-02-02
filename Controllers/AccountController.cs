using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
