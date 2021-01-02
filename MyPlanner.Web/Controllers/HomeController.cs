using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPlanner.Data.Models;
using MyPlanner.Data.Services;
using MyPlanner.Web.Models;

namespace MyPlanner.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPlannerTasks db;
        private string AppName { get; }
        public HomeController(IPlannerTasks db) {
            this.db = db;
            this.AppName = ConfigurationManager.AppSettings["AppName"];
        } 
        public ActionResult Index()
        {
            var model = new HomeData();
            model.AppName = this.AppName;
            model.MyTasks = this.db.GetAllTasks();
            model.UserName = HttpContext.Request.QueryString["uname"] ?? "Anonymous User";
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}