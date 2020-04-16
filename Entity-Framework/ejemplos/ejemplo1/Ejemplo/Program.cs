using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Agregar un dispositivo agregandolo al contexto

            //using (var context = new ExampleContext())
            //{
            //    var device = new Device() { Name = "Device 1" };
            //    var reading = new Reading() { Device = device, Lecture = 20 };
            //    device.Readings.Add(reading);

            //    context.Devices.Add(device);
            //    context.SaveChanges();
            //}

            // 2. Agregar un dispositivo jugando con el estado del objeto

            //using (var context = new ExampleContext())
            //{
            //    var device = new Device() { Name = "Device 2" };
            //    var reading = new Reading() { Device = device, Lecture = 40 };
            //    device.Readings.Add(reading);

            //    context.Entry(device).State = EntityState.Added;
            //    context.SaveChanges();
            //}

            // 3. Trayendo un dispositivo con sus readings -- Eager Loading

            //using (var context = new ExampleContext())
            //{
            //    // Query way
            //    var device = (from d in context.Devices.Include(x => x.Readings) where d.Name == "Device 2" select d).FirstOrDefault();

            //    // Method way
            //    var device = context.Devices.Include(x => x.Readings).Where(x => x.Name == "Device 2").FirstOrDefault();
            //}

            // 4. Editando un dispositivo

            //using (var context = new ExampleContext())
            //{
            //    var device = context.Devices.FirstOrDefault();

            //    device.Name = "Device editado";

            //    context.SaveChanges();
            //}

            // 5. Eliminando una reading de un dispositivo, jugando con el estado

            //using (var context = new ExampleContext())
            //{
            //    var device = context.Devices
            //        .Include(x => x.Readings)
            //        .Where(x => x.Readings.Count > 0)
            //        .FirstOrDefault();

            //    var reading = device.Readings.First();

            //    context.Entry(reading).State = EntityState.Deleted;
            //    context.SaveChanges();
            //}

            Console.ReadLine();
        }
    }
}
