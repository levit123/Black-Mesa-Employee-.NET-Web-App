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
    public class Employment
    {
        public int EmploymentID { get; set; }
        public int EmployeeID { get; set; }
        public int ExperimentID { get; set; }
        public int LocationID { get; set; }
        public BMSecurity SecurityLevel { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Experiment Experiment { get; set; }
        public virtual Location Location { get; set; }
    }
}