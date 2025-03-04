using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Heads
    {
        public int Id { get; set; }
        public int TeachersId { get; set; }
        public Teachers Teacher { get; set; }
        public Heads() { }
    }
}
