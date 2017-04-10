using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBinding.ViewModels;

namespace DataBinding.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View(new RegisterForm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RegisterForm register)
        {
            if (ModelState.IsValid)
            {
                // return to home page
                return RedirectToAction("Index", "Home");
            }
            // return the current page with model and the validion result.
            return View(register);
        }
    }
}