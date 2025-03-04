using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations_hw
{
    public class GroupsLectures
    {
        public int Id { get; set; }
        public int GroupId {  get; set; }
        public int LectureId { get; set; }

        public Groups Group { get; set; }
        public Lectures Lectures { get; set; }

        public GroupsLectures() { }
    }
}
