using ABC_Publicasions.Models;
using ABC_Publicasions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC_Publicasions.Controllers
{
    public class HomeController : Controller
    {
        private JsonDeserialiserService jsonDeserialiserService = new JsonDeserialiserService();
        public ActionResult Index()
        {
            //var prefared = jsonDeserialiserService.DeserialiseJson();
            //var subsection = jsonDeserialiserService.GetDataFromDictionery(prefared.DictContent, prefared.Preface.navigation[0].section);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //var prefared = jsonDeserialiserService.DeserialiseJson();
            //var subsection = jsonDeserialiserService.GetDataFromDictionery(prefared.DictContent, prefared.Preface.navigation[0].section);
            return View();
        }


        public ActionResult Navigate(string key= "preface")
        {
            var rootObject= jsonDeserialiserService.DeserialiseJson();
            var genericMapClass = new GenericMap();
            if (!String.IsNullOrEmpty(key))
            {
                genericMapClass = jsonDeserialiserService.GetDataFromDictionery(rootObject.DictContent, key);
            }
           
            return View(genericMapClass);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}