using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using welcome_to_web.Models;
using System.IO;


namespace welcome_to_web.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string name, string email)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            using ( var writer = new StreamWriter(System.IO.File.Open($"emails.csv",FileMode.Append)))
            {
                writer.WriteLine($"{name},{email}");
            }
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}