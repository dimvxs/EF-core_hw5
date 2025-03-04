using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Deans
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teachers Teacher {  get; set; }
        public Deans() { }
    }
    }

