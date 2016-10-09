using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeamUserRole> TeamUserRoles { get; set; }
    }
}
