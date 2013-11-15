using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DOB { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}