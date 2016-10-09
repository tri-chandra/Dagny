using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class TeamUserRole
    {
        public int ID { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int TeamRoleId { get; set; }
        public TeamRole TeamRole { get; set; }
    }
}
