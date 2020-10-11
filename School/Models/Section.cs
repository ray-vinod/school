using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Section
    {
        //propeties
        public int SectionId { get; set; }
        [Required]
        [Display(Name = "Section Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string SectionName { get; set; }

        //navigation
        public int GradeId { get; set; }
        public virtual Grade Grade {get;set;}
    }
}
