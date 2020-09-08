using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    public class Carrito
    {
        // private Entrada[] entradas = new Entrada[2];
        // private int cantidadDeEntradas = 0;

        public List<Entrada> entradas;

        public Carrito()
        {
            this.entradas = new List<Entrada>();
        }

        public int Checkout(Tarjeta tarjeta = null)
        {
            int montoTotal = 0;

            //for (var i = 0; i < entradas.Length; i++)
            //{
            //    montoTotal += entradas[i].Monto;
            //}

            foreach (var entrada in entradas)
            {
                montoTotal += entrada.Monto;
            }

            return this.AplicarDescuento(montoTotal, tarjeta);
        }

        public void Agregar(Entrada entrada)
        {
            this.entradas.Add(entrada);
            // this.entradas[cantidadDeEntradas] = entrada;
            // this.cantidadDeEntradas++;
        }

        private int AplicarDescuento(int montoTotal, Tarjeta tarjeta = null)
        {
            if (tarjeta != null)
            {
                return (int)(montoTotal * tarjeta.Descuento);
            }
            else
            {
                return montoTotal;
            }
        }
    }
}
