﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int PersonID { get; set; }
        public virtual Person People { get; set; }
        public virtual ICollection<SalesSummary> SalesSummaries { get; set; }
    }
}