using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Http;


namespace DojoSurvey.Controllers {
    public class MainController : Controller {
        [HttpGet ("")]
        public IActionResult Index () {
            return View ();
        }
        
       [HttpPost("process")]
        public IActionResult Process(Survey Submitted)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine($"{Submitted.Name} | {Submitted.Location} | {Submitted.FavLang} | {Submitted.Comment}");

                ViewBag.Survey = Submitted;
                // ViewBag.Count = count;
                return View("Results");

            }else{
                return View("Index");
            }
        }
    }
}