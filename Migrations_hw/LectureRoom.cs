using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class LectureRoom
    {
        public int Id { get; set; }
        public string Building {  get; set; }
        public string Name { get; set; }    
        public List<Shedules> Shedules { get; set; } = new List<Shedules>();
        public LectureRoom() { }
    }
}
