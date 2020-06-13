using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace portfoliotwo.Controllers {
    public class MainController : Controller {
        [HttpGet ("")]
        public ViewResult Index () {
            return View ();
        }
        [HttpGet("result")]
        public ViewResult Result(string Name, string Dojo, string Lang, string Comment){
            ViewBag.Name = Name;
            ViewBag.Dojo = Dojo;
            ViewBag.Lang = Lang;
            ViewBag.Comment = Comment;
            return View();
        }

        [HttpGet ("{res}")]
        public IActionResult Director (string res) {
            if (res == "home") {
                return RedirectToAction ("Index");
            }
            return View ();
        }

        [HttpPost("survey")]
        public IActionResult Survey(string NameField, string DojoField, string LangField, string CommentField)
        {
            // ViewBag.Name = NameField;
            // ViewBag.Dojo = DojoField;
            // ViewBag.Lang = LangField;
            // ViewBag.Comment = CommentField;
            // return View();
            return RedirectToAction("result", new {
                Name = NameField, 
                Dojo = DojoField,
                Lang = LangField,
                Comment = CommentField
            });
            
        }

    }
}