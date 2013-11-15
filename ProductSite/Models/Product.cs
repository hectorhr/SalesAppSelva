using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        
        [Column(TypeName = "Money")]
        public decimal Price { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        
        [Column(TypeName = "image")]
        public byte[] Image { get; set; }
        [Display(Name = "Display Catalog Item")]
        public bool DisplayItem { get; set; }
    }
}