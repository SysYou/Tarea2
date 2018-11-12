using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tarea2.Tests
{
    [TestClass]
    public class OrderDetailPropiedadTesting
    {

        [TestMethod]
        public void Descuento()
        {
            // defino el escenario inicial
            var laEspecificacion = new Tarea2.Logica.Especificaciones.Order_Detail();



            var elResultadoEsperado = 2.226;

            // invoco al método de la prueba
            var elResultadoReal = laEspecificacion.ConsultarPorId(10250);

            // verifico que el resultado sea el esperado
            Assert.IsNotNull(elResultadoReal);
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);

        }

    }
}
