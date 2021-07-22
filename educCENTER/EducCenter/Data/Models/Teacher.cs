
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Teacher 
    {
        public Teacher()
        {
            this.Courses = new HashSet<TeacherCourse>();
            this.Subjects = new HashSet<Subject>();

        }
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }


        public bool IsParent { get; set; }

        public ICollection<Subject> Subjects { get; set; }

        public ICollection<TeacherCourse> Courses { get; set; }

    }
}
