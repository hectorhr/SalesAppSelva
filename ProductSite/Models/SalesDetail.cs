using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class SalesDetail
    {
        public int SalesDetailID { get; set; }
        public int SalesSummaryID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "Money")]
        public decimal Price { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateModified { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual SalesSummary SalesSummary { get; set; }

        public object CustomerID { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }
    }
}