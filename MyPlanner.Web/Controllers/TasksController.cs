using MyPlanner.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPlanner.Web.Controllers
{
    public class TasksController : Controller
    {
        private IPlannerTasks db;

        public TasksController(IPlannerTasks userTasks)
        {
            this.db = userTasks;
        }
        // GET: Tasks
        public ActionResult ShowAll()
        {
            var model = this.db.GetAllTasks();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = this.db.Get(id);
            return View(model);
        }
    }
}