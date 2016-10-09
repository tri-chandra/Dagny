using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Project DefaultProject { get; set; }

        public int AccountRoleId { get; set; }
        public AccountRole AccountRole { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<TeamUserRole> TeamUserRoles { get; set; }

        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}
