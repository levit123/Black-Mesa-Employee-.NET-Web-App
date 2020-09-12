using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Black_Mesa_Website.Models
{
    public enum BMSecurity
    {
        Level1, Level2, Level3, Level4
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BMSecurity SecurityClearance { get; set; }
        public string Biography { get; set; }
    }
}