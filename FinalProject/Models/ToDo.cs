using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class ToDo
    {
        //ToDo acts as a ToDoList object, holding a list of tasks
        public int ID { get; set; }
        public string Text { get; set; } //Text acts as a tempVariable for passing the new ToDo text to the end of ToDo Lists
        public List<string> ToDos { get; set;} //The 
    }
}