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
    public class MailingListController : Controller
    {
        public IActionResult Index()
        {
            var contacts = new Dictionary<string, string>();
            using (var reader = new StreamReader(System.IO.File.Open("emails.csv", FileMode.Open)))
                while (reader.Peek() >= 0)
                {
                    var user = reader.ReadLine();
                    var data = user.Split(',');
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (contacts.ContainsKey(data[i]) == false && contacts.ContainsValue(data[i]) == false)
                            contacts.Add(data[i], data[i + 1]);
                    }
                }
            return View(contacts);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}