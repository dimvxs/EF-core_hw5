using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int DepartmentId { get; set; }
        public Departments Department { get; set; }
        public List<GroupsCurators> GroupsCurators { get; set; } = new List<GroupsCurators>();
        public List<GroupsLectures> GroupsLectures { get; set; } = new List<GroupsLectures>();
 


        public Groups() { }
    }
}
