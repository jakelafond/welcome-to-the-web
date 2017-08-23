using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using welcome_to_web.Models;

namespace welcome_to_web.Controllers
{
    public class APIController : Controller
    {
        [Route("/api")]
        public IActionResult API()
        {
            var jake = new APIModel{
                Name = "Jake",
                FavoriteColor = "Black",
                FavoriteFood = "Pizza"
            };
            return Json(jake);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
