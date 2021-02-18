using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Black_Mesa_Website.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public DateTime EmploymentDate { get; set; }
        public virtual ICollection<Employment> Employments { get; set; }
    }
}