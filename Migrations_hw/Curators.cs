using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Curators
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<GroupsCurators> GroupsCurators { get; set; } = new List<GroupsCurators>();

        public Curators() { }
    }
}
