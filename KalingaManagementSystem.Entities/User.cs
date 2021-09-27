using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaManagementSystem.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoin{ get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; }
        public int LeadId { get; set; }

    }
}
