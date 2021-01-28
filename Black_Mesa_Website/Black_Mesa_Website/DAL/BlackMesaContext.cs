using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Black_Mesa_Website.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Black_Mesa_Website.DAL
{
    public class BlackMesaContext : DbContext
    {
        //constructor with the name of the connection string passed into it
        public BlackMesaContext() : base("BlackMesaContext")
        {

        }

        //specifies the entity sets to use when generating the context and structure of the database.
        //an entity set in this framework corresponds to a table in an SQL database, while a single entity
        //within that entity set corresponds to a row in that table.
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Experiment> Experiments { get; set; }
        public DbSet<Employment> Employments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}