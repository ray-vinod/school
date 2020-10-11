using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student : Person
    {
        //properties
        //[Key]
        public Guid RegistrationNo { get; set; }
        [Required]
        public int RollNo { get; set; }

        //navigation
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
        public virtual List<Address> Address { get; set; }
        //public int AddressId { get; set; }
        //public int ContactId { get; set; }
        public virtual List<Contact> Contact { get; set; }
    }
}
