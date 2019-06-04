using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AmountOfMaintenances { get; set; }
        public ICollection<Reading> Readings { get; set; }

        public Device()
        {
            Readings = new List<Reading>();
        }
    }
}
