using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Bouns { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }



        [InverseProperty("Manager")]
        public Department department { get; set; }

        [InverseProperty("Instructors")]
        [ForeignKey("Dept_Id")]
        public Department dept { get; set; }


        public ICollection<Course_Inst> Course_Inst { get; set; } = new HashSet<Course_Inst>();

    }
}
