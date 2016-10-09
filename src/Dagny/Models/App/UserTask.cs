using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagny.Models.App
{
    public class UserTask
    {
        public int ID { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
