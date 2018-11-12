using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Acciones
{
    public class Orders
    {
        public IList<Tarea2.Order> ConsultarOrdenesPorRangoFechas(DateTime desde, DateTime hasta)
        {
            var elRepositorio = new Tarea2.Logica.Repositorio.Orders();
            var elResultado = elRepositorio.ConsultarOrdenesPorRangoFechas(desde, hasta);
            return elResultado;
        }

        public IList<Tarea2.Order> ConsultarOrdenesPorNombreCiudad(string ciudad)
        {
            var elRepositorio = new Tarea2.Logica.Repositorio.Orders();
            var elResultado = elRepositorio.ConsultarOrdenesPorNombreCiudad(ciudad);
            return elResultado;
        }

        public IList<Tarea2.Order> ConsultarOrdenesPorNombreCliente(string cliente)
        {
            var elRepositorio = new Tarea2.Logica.Repositorio.Orders();
            var elResultado = elRepositorio.ConsultarOrdenesPorNombreCliente(cliente);
            return elResultado;
        }

        public IList<Tarea2.Order> ConsultarOrdenesPorNombreVendedor(string vendedor)
        {
            var elRepositorio = new Tarea2.Logica.Repositorio.Orders();
            var elResultado = elRepositorio.ConsultarOrdenesPorNombreVendedor(vendedor);
            return elResultado;
        }
    }
}