using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Http;


namespace portfoliotwo.Controllers {
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


        // [HttpPost("survey")]
        // public IActionResult Survey(string NameField, string DojoField, string LangField, string CommentField)
        // {
        //     // ViewBag.Name = NameField;
        //     // ViewBag.Dojo = DojoField;
        //     // ViewBag.Lang = LangField;
        //     // ViewBag.Comment = CommentField;
        //     // return View();
        //     return RedirectToAction("result", new {
        //         Name = NameField, 
        //         Dojo = DojoField,
        //         Lang = LangField,
        //         Comment = CommentField
        //     });
            
        // }
        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}