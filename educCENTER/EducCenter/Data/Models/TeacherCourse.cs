
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

    public class TeacherCourse
    {
        public int Id { get; set; }

        [Required]       
        public string CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Required]
        public string TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        
    }
}
