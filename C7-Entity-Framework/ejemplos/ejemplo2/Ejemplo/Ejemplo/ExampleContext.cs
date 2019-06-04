using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class ExampleContext : DbContext
    {
        public DbSet<Reading> Readings { get; set; }
        public DbSet<Device> Devices { get; set; }

        public ExampleContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ExampleContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DeviceTypeConfiguration());
        }
    }
}
