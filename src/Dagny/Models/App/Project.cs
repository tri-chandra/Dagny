using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Goal { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProjectUser> ProjectUsers { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Backlog> Backlogs { get; set; }
    }
}
