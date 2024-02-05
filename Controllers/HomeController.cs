using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using programmeringmed.Net2.Models;
using System.Collections.Generic;

namespace MyApp.Namespace
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            var jsonStr = System.IO.File.ReadAllText("courses.json");
            var JsonObj = JsonConvert.DeserializeObject<IEnumerable<Courses>>(jsonStr);
            return View(JsonObj);
        }
        //Ändrar namn i url
        [Route("/Form")]
        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }
        //Ändrar namn i url
        [Route("/Form")]
        [HttpPost]
        public ActionResult Form(Person model)
        {   
            if (ModelState.IsValid)
            {
                // Bara om alla obligatoriska fält är ifyllda
                string s = "Detta skickas med ViewBag:";
                ViewBag.s = s;
                ViewBag.test = $"{model.fname} {model.lname}, {model.gender}, {model.age} år, {model.work}";
                return View(model);
            }
            else
            {
                // Om det finns valideringsfel, returnera vyn med felmeddelanden
                return View(model);
            }
        }
                //Ändrar namn i url
        [Route("/ViewData2")]
        [HttpGet]
        public ActionResult ViewData2()
        {
            return View();
        }
       [Route("/ViewData2")]
        [HttpPost]
        public ActionResult ViewData2(Calc model)
        {
            if (ModelState.IsValid)
            {
                // Räkna ihop talen och lagra resultatet i ViewData
                model.Result = model.Num1 + model.Num2;
                ViewData["Result"] = model.Result;
            }

            return View();
        }

    }
}
