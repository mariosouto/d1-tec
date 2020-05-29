namespace BusinessLogic
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {
        public MyContext() : base("MyDBConnectionString")
        {
            Database.SetInitializer<MyContext>(new DropCreateDatabaseIfModelChanges<MyContext>());
        }

        public DbSet<Person> MyPersons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
        }
    }
}