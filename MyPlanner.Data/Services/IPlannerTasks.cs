using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPlanner.Data.Models;

namespace MyPlanner.Data.Services
{
    public interface IPlannerTasks
    {
        IEnumerable<PlannerTask> GetAllTasks();
        PlannerTask Get(int Id);
    }
}
