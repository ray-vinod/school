using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Teacher : Person
    {
        public enum ServiceType
        {
            Temporary,
            Permanent,
            PartTime,
        }
        public enum Position
        {
            Principal,
            Teacher,
            Coordinatory,
            ClassTeacher
        }
        //public int Id { get; set; }
        public string AssignedSubject { get; set; }
        public ServiceType serviceType { get; set; }
        public Position position { get; set; }

        //navigation
        public virtual List<Address> Address { get; set; }
        //public int AddressId { get; set; }
        //public int ContactId { get; set; }
        public virtual List<Contact> Contact { get; set; }
    }
}
