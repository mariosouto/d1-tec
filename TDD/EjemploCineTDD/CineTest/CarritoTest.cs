using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cine;

namespace CineTest
{
    [TestClass]
    public class CarritoTest
    {

        [TestMethod]
        public void CompraRegularDeDosEntradasTest()
        {
            Carrito carrito = new Carrito();
            carrito.Agregar(new Entrada() { Monto = 150, Pelicula = "Star Wars" });
            carrito.Agregar(new Entrada() { Monto = 150, Pelicula = "Star Wars" });

            int montoTotal = carrito.Checkout();

            Assert.AreEqual(300, montoTotal);
        }

        [TestMethod]
        public void CompraDeDosEntradasConTarjeta()
        {
            Carrito carrito = new Carrito();
            carrito.Agregar(new Entrada() { Monto = 150, Pelicula = "Star Wars" });
            carrito.Agregar(new Entrada() { Monto = 150, Pelicula = "Star Wars" });

            int montoTotal = carrito.Checkout(new Tarjeta { Marca = "ITAU", Descuento = 0.5 });

            Assert.AreEqual(150, montoTotal);
        }
    }
}
