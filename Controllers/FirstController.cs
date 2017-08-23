using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using welcome_to_web.Models;

namespace welcome_to_web.Controllers
{
    public class FirstController : Controller
    {
         [Route("/First")]
        public IActionResult First()
        {
            ViewData["Message"] = "Hello World!";
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
