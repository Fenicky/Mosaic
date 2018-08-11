using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class ToDoController : Controller
    {

        ToDo todo = new ToDo { Text = "Test To Do List", ToDos = new List<string>() }; //Init our first list of ToDo tasks

        public ActionResult Index()
        {
            //Populate Site with dummy task lists for testing
            todo.ToDos.Add("This is Task 1");
            todo.ToDos.Add("This is Task 2");
            todo.ToDos.Add("This is Task 3");
            todo.ToDos.Add("This is Task 4");
            todo.ToDos.Add("This is Task 5");

            return View(todo);
        }

        //Method for adding new string to list of ToDos, then passing the updated object to the view
        [HttpPost]
        public ActionResult Create(string Text)
        {
            todo.ToDos.Add(Text);
            return View(todo);
        }
    }
}