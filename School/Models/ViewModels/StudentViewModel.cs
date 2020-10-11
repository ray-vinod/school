using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public int RollNo { get; set; }
        [Display(Name ="First Name")]
        public string FName { get; set; }
        [Display(Name = "Middle Name")]
        public string MName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Display(Name ="Grade")]
        public string Grade { get; set; }
       
    }
}
