using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Teachers
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public int? Salary { get; set;}
        public string Surname { get; set;}
        public List<Lectures> Lectures { get; set; } = new List<Lectures>();

        public Teachers()
        { }

    }
}
