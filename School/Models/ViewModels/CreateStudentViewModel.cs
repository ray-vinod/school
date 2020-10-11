using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModels
{
    public class CreateStudentViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Registration No")]
        public Guid RegistrationNo { get; set; }
        [Display(Name ="Roll No")]
        public int RollNo { get; set; }
        [Display(Name ="First Name")]
        public string FName { get; set; }
        [Display(Name = "Middle Name")]
        public string MName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}",ApplyFormatInEditMode =true)]
        public DateTime DOB { get; set; }

        public int GradeId { get; set; }
        public SelectList GradeList { get; set; }
        //public IEnumerable<Grade> Grades { get; set; }
        public int SectionId { get; set; }
        public SelectList SectionList { get; set; }
        //public IEnumerable<Section> Sections { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }


    }
}
