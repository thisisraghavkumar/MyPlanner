using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPlanner.Data.Models;

namespace MyPlanner.Web.Models
{
    public class HomeData
    {
        public string AppName { get; set; }
        public string UserName { get; set; }
        public IEnumerable<PlannerTask> MyTasks { get; set; }
    }
}