using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Repositorio
{
    public class Orders
    {
        northwindEntities _contexto = new northwindEntities();

        public Orders()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        internal IList<Tarea2.Order> ConsultarOrdenesPorRangoFechas(DateTime desde, DateTime hasta)
        {
            IList<Tarea2.Order> elResultado = _contexto.Orders.Where(c => c.OrderDate >= desde && c.OrderDate <= hasta).ToList();
            // LimpiarPropiedadesDeNavegacion(ref elResultado);
            return elResultado;
        }

        internal IList<Tarea2.Order> ConsultarOrdenesPorNombreCiudad(string ciudad)
        {
            IList<Tarea2.Order> elResultado = _contexto.Orders.Where(c => c.ShipCity.Equals(ciudad)).ToList();
            // LimpiarPropiedadesDeNavegacion(ref elResultado);
            return elResultado;
        }

        internal IList<Tarea2.Order> ConsultarOrdenesPorNombreCliente(string cliente)
        {
            IList<Tarea2.Order> elResultado = _contexto.Orders.Include("Customer").Where(c => c.Customer.ContactName.Equals(cliente)).ToList();
            // LimpiarPropiedadesDeNavegacion(ref elResultado);
            return elResultado;
        }

        internal IList<Tarea2.Order> ConsultarOrdenesPorNombreVendedor(string vendedor)
        {
            IList<Tarea2.Order> elResultado = _contexto.Orders.Include("Employee").Where(c => c.Employee.FirstName.Equals(vendedor)).ToList();
            // LimpiarPropiedadesDeNavegacion(ref elResultado);
            return elResultado;
        }
    }
}