using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class DeviceTypeConfiguration : EntityTypeConfiguration<Device>
    {
        public DeviceTypeConfiguration()
        {
            this.Property(x => x.Name).HasMaxLength(30);
            this.Ignore(x => x.AmountOfMaintenances);
        }
    }
}
