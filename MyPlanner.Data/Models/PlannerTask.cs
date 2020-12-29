using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlanner.Data.Models
{
    public class PlannerTask
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime Created { get; }
        public DateTime Due { get; set; }
        public bool IsImportant { get; set; }
        public bool IsUrgent { get; set; }
        public int TotalSteps { get; set; }
        public int CompletedSteps { get; set; }
        public string Steps { get; set; }
        
        public PlannerTask()
        {
            this.Created = DateTime.Now;
            this.Due = DateTime.Now.AddDays(10);
        }
    }

}
