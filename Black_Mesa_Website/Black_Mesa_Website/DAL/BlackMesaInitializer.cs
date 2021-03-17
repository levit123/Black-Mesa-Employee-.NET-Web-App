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
                new Employee{FirstName="Gordon", LastName="Freeman", 
                Biography="MIT Graduate. Quantum Physicist. Trained Xen crystal tester. These are just some of the terms used to describe " +
                "Dr. Freeman, who has quickly worked his way from college into Black Mesa's testing facility. While certainly intelligent, " +
                "also has skills as a handyman, and is quickly able to pick up any tool and quickly learn to use it. Has a tendency to crawl " +
                "through the vents. Sometimes shows up late.",
                EmploymentDate = DateTime.Parse("05/09/1999")},
                new Employee{FirstName="Isaac", LastName="Kleiner",
                Biography="Graduating top of his class at MIT, and former mentor of Gordon Freeman, Kleiner is a brilliant, albeit " +
                "neurotic and paranoid, scientist who has excelled at a variety of research subjects at Black Mesa. From quantum physics " +
                "to anomolous materials to astrobiology, Kleiner has proved to be a valuable asset to Black Mesa. This is why we were " +
                "willing to accept his proposal to bring Gordon Freeman onto the team. In addition, it seems Kleiner and the team is not " +
                "the only one interested in Dr. Freeman's skills. But that's above our pay grade, isn't it?",
                EmploymentDate = DateTime.Parse("06/10/1998")},
                new Employee{FirstName="Barney", LastName="Calhoun", 
                Biography="Security guard trained in firearms, and a bit of a goof, to be honest. Seems to get along quite well with Gordon " +
                "and Dr. Kleiner, although has short patience with the latter. When Dr. Kleiner locks his keys in his office - happens " +
                "more often than you think - he and Gordon will race each other to see who can crawl through the vents the quickest to " +
                "get into Kleiner's office.",
                EmploymentDate=DateTime.Parse("03/05/1999")},
                new Employee{FirstName="[EXPUNGED]", LastName="G-Man",
                Biography="[EXPUNGED]" + "\n" + "ADDENDUM: Under no circumstances is any info, conspiracies, or mentions of this employee " +
                "to be on this site. For all intensive purposes, he doesn't exist. His work is far beyond any average folk such as us.",
                EmploymentDate=DateTime.Parse("01/01/2000")}
            };

            //iterates through the list of Employees and adds each one to the context for the database
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var locations = new List<Location>
            {
                new Location{LocationName="Primary Testing Facility", LocationInfo="Consists of multiple offices, break rooms, labs, and " +
                "and test chambers for various experiments, including hazardous materials. Area is to be monitored heavily by standard security, " +
                "and employees are expected to present employee ID's upon arriving via tram." },
                new Location{LocationName="Rocket Site", LocationInfo="Consists of launchpad, maintenance tunnels, rocket silos, " +
                "and observation area for launching space rockets containing satelites, planet probes, and other devices into space."},
                new Location{LocationName="Toxic Waste Handling", LocationInfo="All toxic waste is to re-direct through here for proper handling " +
                "and disposal. HEV suits are required for entering anywhere beyond the entrance to this area."},
                new Location{LocationName="Hydro Generators", LocationInfo="Housing and maintenance area for large water-powered generators that " +
                "power various parts of the overall research facility. Personal travel through underwater maintenance tunnels not recommended " +
                "due to potential of radiation leak if the generators accrue sufficient damage."},
                new Location{LocationName="Xen Portal Site", LocationInfo="[REDACTED]"}
            };

            //iterates through the list of Locations and adds each one to the context for the database
            locations.ForEach(s => context.Locations.Add(s));
            context.SaveChanges();

            var employments = new List<Employment>
            {
                new Employment{EmployeeID=1, EmploymentID=363, LocationID=1, SecurityLevel=BMSecurity.Level2},
                new Employment{EmployeeID=2, EmploymentID=172, LocationID=3, SecurityLevel=BMSecurity.Level3},
                new Employment{EmployeeID=3, EmploymentID=203, LocationID=2, SecurityLevel=BMSecurity.Level1},
                new Employment{EmployeeID=4, EmploymentID=000, LocationID=4, SecurityLevel=BMSecurity.Level4}
            };

            //iterates through the list of Employments and adds each one to the context for the database
            employments.ForEach(s => context.Employments.Add(s));
            context.SaveChanges();

        }
    }
}