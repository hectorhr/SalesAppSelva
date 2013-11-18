using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class SalesSummary
    {
        public int SalesSummaryID { get; set; }
        public int CustomerID { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime TransactionTime { get; set; }
        [Column(TypeName="Money")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "Money")]
        public decimal TaxAmt { get; set; }
        [Column(TypeName = "Money")]
        public decimal TotalPrice { get; set; }
        [Column(TypeName = "DateTime2")]
        public decimal ModifiedDate { get; set; }
        
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }        
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public object ProductID { get; set; }
    }
}