using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateOnly HiringDate { get; set; }

        [InverseProperty("department")]
        [ForeignKey("Ins_Id")]
        public Instructor Manager { get; set; }

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        [InverseProperty("dept")]

        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();


    }
}
