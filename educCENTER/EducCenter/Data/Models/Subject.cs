
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Subject
    {
        public Subject()
        {
            this.Subjects = new HashSet<Subject>();
        }
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; }


        [MaxLength(SubjectDescriptionMax)]
        public string Description { get; set; }

        public IEnumerable<Subject> Subjects;
        
        public Teacher TeacherId { get; set; }

    }
}
