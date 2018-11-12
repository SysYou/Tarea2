using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Especificaciones
{
    public class Orders
    {
        public IList<Tarea2.Order> ConsultarOrdenesPorRangoFechas(DateTime desde, DateTime hasta)
        {
            var laAccion = new Tarea2.Logica.Acciones.Orders();
            var elResultado = laAccion.ConsultarOrdenesPorRangoFechas(desde, hasta);
            return elResultado;
        }

        public IList<Tarea2.Order> ConsultarOrdenesPorNombreCiudad(string ciudad)
        {
            var laAccion = new Tarea2.Logica.Acciones.Orders();
            var elResultado = laAccion.ConsultarOrdenesPorNombreCiudad(ciudad);
            return elResultado;
        }

        public IList<Tarea2.Order> ConsultarOrdenesPorNombreCliente(string cliente)
        {
            var laAccion = new Tarea2.Logica.Acciones.Orders();
            var elResultado = laAccion.ConsultarOrdenesPorNombreCliente(cliente);
            return elResultado;
        }

        public IList<Tarea2.Order> ConsultarOrdenesPorNombreVendedor(string vendedor)
        {
            var laAccion = new Tarea2.Logica.Acciones.Orders();
            var elResultado = laAccion.ConsultarOrdenesPorNombreVendedor(vendedor);
            return elResultado;
        }
    }
}