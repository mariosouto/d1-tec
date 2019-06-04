using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class Device
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        // No quiero generar una columna para este atributo
        [NotMapped]
        public int AmountOfMaintenances { get; set; }

        public ICollection<Reading> Readings { get; set; }

        public Device()
        {
            Readings = new List<Reading>();
        }
    }
}
