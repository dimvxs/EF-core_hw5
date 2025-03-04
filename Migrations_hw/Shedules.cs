using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Shedules
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public int DayOfWeek { get; set; }
        public int Week {  get; set; }
        public int LectureId { get; set; }
        public int LectureRoomId { get; set; }
        public Lectures Lectures { get; set; }
        public LectureRoom LectureRoom { get; set; }
        public Shedules() { }
    }
}
