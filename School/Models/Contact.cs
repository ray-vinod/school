using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Contact
    {
        //properties
        public int ContactId { get; set; }
        [Required]
        //[RegularExpression("^\\+[0-9]{3}\\s+[0-9]{10}$")]       
        public int MobileNo { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Residence { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Office { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //navigation
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        
    }
}
