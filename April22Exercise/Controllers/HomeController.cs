using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using April22Exercise.Models;

namespace April22Exercise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Reverser(string x)
        {
            string result = "";
            for(int i = x.Length-1; i >= 0; i--)
            {
                result += x[i];
            }
            return Json(result);
        }

    }
}
