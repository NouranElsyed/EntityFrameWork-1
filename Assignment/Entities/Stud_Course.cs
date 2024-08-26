using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Stud_Course
    {
        [ForeignKey("Student")]
        public int Stud_Id { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }
        public int Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
