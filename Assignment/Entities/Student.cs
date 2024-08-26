using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        [InverseProperty("Students")]
        [ForeignKey("Dept_Id")]
        public Department department { get; set; }

        public ICollection<Stud_Course> stud_Course { get; set; }   = new HashSet<Stud_Course>();   
    }
}
