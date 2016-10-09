using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class Backlog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public virtual ICollection<Task> tasks { get; set; }
    }
}
