
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Course
    {
        public Course()
        {
            this.Teachers = new HashSet<TeacherCourse>();
            this.Students = new HashSet<StudentCourse>();

        }
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public ICollection<TeacherCourse> Teachers { get; set; }

        public ICollection<StudentCourse> Students { get; set; }

    }
}
