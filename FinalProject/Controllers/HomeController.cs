using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var toDo = new ToDo()
            {
                Text = "You gotta finish this app now"
            };
            return View(toDo);
        }
    }
}