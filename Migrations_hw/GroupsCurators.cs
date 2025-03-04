using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class GroupsCurators
    {

        public int Id { get; set; }
        public int GroupId { get; set; }
        public int CuratorId { get; set; }

        public Groups Group { get; set; }
        public Curators Curator { get; set; }

        public GroupsCurators() { }

    }
}
