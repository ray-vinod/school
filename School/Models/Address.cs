using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Address
    {
        //properties
        public int AddressId { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Temporary { get; set; }
        [Required]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$+[0-9]")]
        [StringLength(30,MinimumLength =3)]
        public string Permanent { get; set; }

        //navigation
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
