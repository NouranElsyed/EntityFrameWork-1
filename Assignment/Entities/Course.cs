using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
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
        public int Top_Id { get; set; }
    }
}
