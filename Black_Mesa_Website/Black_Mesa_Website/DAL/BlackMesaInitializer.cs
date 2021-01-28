using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Black_Mesa_Website.Models;

namespace Black_Mesa_Website.DAL
{
    public class BlackMesaInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<BlackMesaContext>
    {
        //populates the database with default starting info
        protected override void Seed(BlackMesaContext context)
        {
            //creates a list of Employee objects and defines their properties' values
            var employees = new List<Employee>
            {
                new Employee{FirstName="Gordon", LastName="Freeman", SecurityClearance=BMSecurity.Level2,
                Biography="MIT Graduate. Quantum Physicist. Trained Xen crystal tester. These are just some of the terms used to describe " +
                "Dr. Freeman, who has quickly worked his way from college into Black Mesa's testing facility. While certainly intelligent, " +
                "also has skills as a handyman, and is quickly able to pick up any tool and quickly learn to use it. Has a tendency to crawl " +
                "through the vents. Sometimes shows up late.",
                EmploymentDate = DateTime.Parse("1999-09-05")},
                new Employee{FirstName="Isaac", LastName="Kleiner", SecurityClearance=BMSecurity.Level3,
                Biography="Graduating top of his class at MIT, and former mentor of Gordon Freeman, Kleiner is a brilliant, albeit " +
                "neurotic and paranoid, scientist who has excelled at a variety of research subjects at Black Mesa. From quantum physics " +
                "to anomolous materials to astrobiology, Kleiner has proved to be a valuable asset to Black Mesa. This is why we were " +
                "willing to accept his proposal to bring Gordon Freeman onto the team. In addition, it seems Kleiner and the team is not " +
                "the only one interested in Dr. Freeman's skills. But that's above our pay grade, isn't it?",
                EmploymentDate = DateTime.Parse("1998-06-10")},
                new Employee{FirstName="Barney", LastName="Calhoun", SecurityClearance=BMSecurity.Level1,
                Biography="Security guard trained in firearms, and a bit of a goof, to be honest. Seems to get along quite well with Gordon " +
                "and Dr. Kleiner, although has short patience with the latter. When Dr. Kleiner locks his keys in his office - happens " +
                "more often than you think - he and Gordon will race each other to see who can crawl through the vents the quickest to " +
                "get into Kleiner's office.",
                EmploymentDate=DateTime.Parse("1999-03-05")},
                new Employee{FirstName="[REDACTED]", LastName="G-Man", SecurityClearance=BMSecurity.Level4,
                Biography="[REDACTED]" + "\n" + "ADDENDUM: What in the absolute hell, what did I tell you when I first assigned you to this site? " +
                "Do not, under any circumstances, include any background details about this guy. It's a huge risk even having a record for this guy " +
                "At all. Do you have any idea who or what this guy works for? Cuz I sure don't. All we've been told is to ignore him when he's on " +
                "the facility grounds, don't even look him in the eye, just let him go about his business. I don't want to see any more info " +
                "about him, even hearing his weird voice gives me the creeps.",
                EmploymentDate=DateTime.Parse("0000-00-00")}
            };

            //iterates through the list of Employees and adds each one to the context for the database
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var locations = new List<Location>
            {

            };

        }
    }
}