using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public abstract class Person
    {
        //properties
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        [StringLength(100,MinimumLength =3)]
        //[RegularExpression(@"[A-Z]+[a-zA-Z""'\s-]*$")]
        public string FName { get; set; }
        [Display(Name = "Middle Name")]
        [StringLength(100, MinimumLength = 3)]
        public string MName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 3)]
        public string LName { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}",ApplyFormatInEditMode =true)]
        public DateTime DOB { get; set; }

        //navigation
    }
}
