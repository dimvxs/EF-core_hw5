using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class Lectures
    {
        public int Id { get; set; }
        public string LectureRoom { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public Subjects Subjects { get; set; }
        public Teachers Teachers { get; set; }
        public List<GroupsLectures> GroupsLectures { get; set; } = new List<GroupsLectures>();

        public Lectures() { }
    }
}
