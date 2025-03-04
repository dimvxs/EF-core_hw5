using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Departments
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Financing {  get; set; }
        public int FacultyId { get; set; }

        public Faculties Faculty { get; set; }
        public List<Groups> Groups { get; set; } = new List<Groups>();

        public Departments() { }
    }
}
