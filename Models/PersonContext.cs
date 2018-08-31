using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tester.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext( ) { }

        public DbSet<Person> Persons { get; set; }
    }
}