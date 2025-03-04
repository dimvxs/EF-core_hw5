using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Faculties
    {
        public int Id { get; set; }
        public int? Financing { get; set; }
        public string Name { get; set; }
        public List<Departments> Departments { get; set; } = new List<Departments>();

        public Faculties() { }


    }
}
