using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tarea2.Tests
{
    [TestClass]
    public class OrderDetailsTesting
    {
        [TestMethod]
        public void DetalleOrdenPorNombreArticuloTest()
        {
            // defino el escenario inicial
            var laEspecificacion = new Tarea2.Logica.Especificaciones.Order_Detail();
            var articulo = "Ikura";
            var elResultadoEsperado = 33;

            // invoco al método de la prueba
            var elResultadoReal = laEspecificacion.ConsultarDetalleOrdenPorNombreArticulo(articulo);

            // verifico que el resultado sea el esperado
            Assert.IsNotNull(elResultadoReal);
            Assert.AreEqual(elResultadoEsperado, elResultadoReal.Count);
        }

        [TestMethod]
        public void DetalleOrdenPorNombreCategoriaTest()
        {
            // defino el escenario inicial
            var laEspecificacion = new Tarea2.Logica.Especificaciones.Order_Detail();
            var categoria = "Seafood";
            var elResultadoEsperado = 12;

            // invoco al método de la prueba
            var elResultadoReal = laEspecificacion.ConsultarDetalleOrdenPorNombreCategoria(categoria);

            // verifico que el resultado sea el esperado
            Assert.IsNotNull(elResultadoReal);
            Assert.AreEqual(elResultadoEsperado, elResultadoReal.Count);
        }
    }
}
