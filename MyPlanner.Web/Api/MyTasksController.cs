using MyPlanner.Data.Models;
using MyPlanner.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyPlanner.Web.Api
{
    public class MyTasksController : ApiController
    {
        private IPlannerTasks db;

        public MyTasksController(IPlannerTasks tasks)
        {
            this.db = tasks;
        }
        public IEnumerable<PlannerTask> Get()
        {
            return this.db.GetAllTasks();   
        }
    }
}
