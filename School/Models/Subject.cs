using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Subject
    {
        //properties
        public int SubjectId { get; set; }
        [Required]
        [Display(Name="Subject Name")]
        public string Name { get; set; }
        public string Author { get; set; }
        [Required]
        public int FullMarks { get; set; }
        [Required]
        public int PassMarks { get; set; }

        //navigarion
    }
}
