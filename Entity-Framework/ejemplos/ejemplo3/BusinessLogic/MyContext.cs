namespace BusinessLogic
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {
        public DbSet<Person> MyPersons { get; set; }
    }
}