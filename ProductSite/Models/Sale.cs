using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int Qty { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}