using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Grade
    {
        //properties
        public int GradeId { get; set; }
        [Required]
        [Display(Name ="Grade Name")]
        [StringLength(2,MinimumLength =1)]
        [RegularExpression(@"[0-9]+[0-9]")]
        public string GradeName { get; set; }

        //navigation
        public virtual List<Section> Sections { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }

    }
}
