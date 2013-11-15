using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int PersonID { get; set; }
        public virtual Person People { get; set; }
        public int ManagerID { get ;set; }
        public virtual Employee ManagerID { get; set; }
    }
}