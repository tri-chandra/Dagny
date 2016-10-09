using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class Task
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int BacklogId { get; set; }
        public Backlog Backlog { get; set; }

        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}
