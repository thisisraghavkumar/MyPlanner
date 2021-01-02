using MyPlanner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlanner.Data.Services
{
    public class InMemoryTasks : IPlannerTasks
    {
        private List<PlannerTask> userTasks;
        public InMemoryTasks()
        {
            var timeNow = DateTime.Now;
            this.userTasks = new List<PlannerTask>()
            {
                new PlannerTask {Id = 1, Subject = "Task 1 Important and Urgent", Due = timeNow.AddDays(5), IsImportant = true, IsUrgent = true, TotalSteps = 17, CompletedSteps = 4, Steps = "Lectures"},
                new PlannerTask {Id = 2, Subject = "Task 2 Important but not Urgent", Due = timeNow.AddDays(500), IsImportant = true, IsUrgent = false, TotalSteps = 10, CompletedSteps = 1, Steps = "Steps"},
                new PlannerTask {Id = 3, Subject = "Task 3 not Important but Urgent", Due = timeNow.AddDays(2).AddHours(5), IsImportant = false, IsUrgent = true, TotalSteps = 3, CompletedSteps = 2, Steps = "Hours"},
                new PlannerTask {Id = 4, Subject = "Task 4 not Important and not Urgent", IsImportant = false, IsUrgent = false},
                new PlannerTask {Id = 5, Subject = "Task 5 Important and Urgent", Due = timeNow.AddDays(10), IsImportant = true, IsUrgent = true, TotalSteps = 10, CompletedSteps = 2, Steps = "Days"}
            };
        }

        // Returns given id or null
        public PlannerTask Get(int Id)
        {
            return userTasks.FirstOrDefault(r => r.Id == Id);
        }

        public IEnumerable<PlannerTask> GetAllTasks()
        {
            return userTasks.OrderBy(r => r.Due);
        }
    }
}
