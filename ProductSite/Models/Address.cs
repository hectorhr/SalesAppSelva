using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string AptNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
}