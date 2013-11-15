using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string? Prefix { get; set; }
        public string FirstName { get; set; }
        public string? Middle { get; set; }
        public string LastName { get; set; }
        public string? Suffix { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DOB { get; set; }
        public long? Phone { get; set; }
        public string Gender { get; set; }
    }
}