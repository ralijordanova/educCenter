using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducCenter.Data.Models
{
    public class Parent
    {
        public int Id { get; init; }

        [Required]
        public string UserId { get; set; }

        public IEnumerable<Student> Students { get; init; } = new HashSet<Student>();
    }
}
