//Dial the data gateway here.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//add in the namespace for DbContext which connects to the backend database.
using System.Data.Entity;

namespace MVC5EF6Tables.Models
{
    //the name of my connection string matches the name of my class EmployeeContext below.
    public class EmployeeContext : DbContext 
    {
        //the property Employees returns a DbSet of Employee below, from the EmployeeContext class above.
        public DbSet<Employee> Employees { get; set; }

        // Step 2. next retrieve DbSet of Departments aswell in the ContextClass.
        public DbSet<Department> Departments { get; set; }

        // Step 3. next implement a Department controller class, RC Controllers folder, add MVC Controller.

        //------- About Us page --------------
        public DbSet<AboutUs> AboutUs { get; set; }
        //------- Church History page--------------
        public DbSet<ChurchHistory> ChurchHistory { get; set; }
        //------- Mission Plan page--------------
        public DbSet<MissionPlan> MissionPlan { get; set; }
        //------- Whats On page--------------
        public DbSet<WhatsOn> WhatsOn { get; set; }
        //------- Services page--------------
        public DbSet<Services> Services { get; set; }
        //------- Christenings page--------------
        public DbSet<Christenings> Christenings { get; set; }
        //------- Hall Hire page--------------
        public DbSet<HallHire> HallHire { get; set; }
        //------- Privacy page--------------
        public DbSet<Privacy> Privacy { get; set; }
        //------- SafeGuarding page--------------
        public DbSet<SafeGuarding> SafeGuarding { get; set; }
        //------- FutureEvents page--------------
        public DbSet<FutureEvents> FutureEvents { get; set; }
        //------- PastEvents page--------------
        public DbSet<PastEvents> PastEvents { get; set; }
        //------- Emilys Party page--------------
        public DbSet<EmilysParty> EmilysParty { get; set; }
        //------- Emily page--------------
        public DbSet<Emily> Emily { get; set; }
        //------- Confirmation page--------------
        public DbSet<Confirmation> Confirmation { get; set; }
        //------- Pentecost page--------------
        public DbSet<Pentecost> Pentecost { get; set; }
        //------- Ascension page--------------
        public DbSet<Ascension> Ascension { get; set; }
        //------- Easter page--------------
        public DbSet<Easter> Easter { get; set; }
        //------- Gallery page--------------
        public DbSet<Gallery> Gallery { get; set; }
        //------- Spotlight page--------------
        public DbSet<Spotlight> Spotlight { get; set; }
        //------- NewsLetter page--------------
        public DbSet<NewsLetter> NewsLetter { get; set; }

    }
}