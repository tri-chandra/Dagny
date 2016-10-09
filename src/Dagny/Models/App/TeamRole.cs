using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class TeamRole
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TeamUserRole> TeamUserRoles { get; set; }
    }
}
