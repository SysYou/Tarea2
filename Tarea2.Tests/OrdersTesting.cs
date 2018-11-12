using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tarea2.Tests
{
    [TestClass]
    public class OrdersTesting
    {
        [TestMethod]
        public void OrdenesRangoFechasTest()
        {
            // defino el escenario inicial
            var laEspecificacion = new Tarea2.Logica.Especificaciones.Orders();
            var fechaDesde = DateTime.Parse("1997-03-05 00:00:00.000");
            var fechaHasta = DateTime.Parse("1997-03-14 00:00:00.000");
            var elResultadoEsperado = 11;

            // invoco al método de la prueba
            var elResultadoReal = laEspecificacion.ConsultarOrdenesPorRangoFechas(fechaDesde, fechaHasta);

            // verifico que el resultado sea el esperado
            Assert.IsNotNull(elResultadoReal);
            Assert.AreEqual(elResultadoEsperado, elResultadoReal.Count);
        }

        [TestMethod]
        public void OrdenesPorNombreCiudadTest()
        {
            // defino el escenario inicial
            var laEspecificacion = new Tarea2.Logica.Especificaciones.Orders();
            var ciudad = "Seattle";
            var elResultadoEsperado = 14;

            // invoco al método de la prueba
            var elResultadoReal = laEspecificacion.ConsultarOrdenesPorNombreCiudad(ciudad);

            // verifico que el resultado sea el esperado
            Assert.IsNotNull(elResultadoReal);
            Assert.AreEqual(elResultadoEsperado, elResultadoReal.Count);
        }

        [TestMethod]
        public void ConsultarOrdenesPorNombreCliente()
        {
            // defino el escenario inicial
            var laEspecificacion = new Tarea2.Logica.Especificaciones.Orders();
            var cliente = "Karin Josephs";
            var elResultadoEsperado = 6;

            // invoco al método de la prueba
            var elResultadoReal = laEspecificacion.ConsultarOrdenesPorNombreCliente(cliente);

            // verifico que el resultado sea el esperado
            Assert.IsNotNull(elResultadoReal);
            Assert.AreEqual(elResultadoEsperado, elResultadoReal.Count);
        }

        [TestMethod]
        public void ConsultarOrdenesPorNombreVendedor()
        {
            // defino el escenario inicial
            var laEspecificacion = new Tarea2.Logica.Especificaciones.Orders();
            var vendedor = "Michael";
            var elResultadoEsperado = 67;

            // invoco al método de la prueba
            var elResultadoReal = laEspecificacion.ConsultarOrdenesPorNombreVendedor(vendedor);

            // verifico que el resultado sea el esperado
            Assert.IsNotNull(elResultadoReal);
            Assert.AreEqual(elResultadoEsperado, elResultadoReal.Count);
        }
    }
}
