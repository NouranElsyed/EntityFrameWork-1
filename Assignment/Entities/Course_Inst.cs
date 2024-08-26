using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Course_Inst
    {
        [ForeignKey("Instructor")]
        public int Inst_Id { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public int Evaluate {  get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
