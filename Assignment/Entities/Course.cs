using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Duration { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Top_Id")]
        public Topic topic { get; set; }

        public ICollection<Stud_Course> stud_Course { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Inst> Course_Inst { get; set; } = new HashSet<Course_Inst>();

    }
}
