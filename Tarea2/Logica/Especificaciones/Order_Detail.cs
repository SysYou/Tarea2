using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Especificaciones
{
    public class Order_Detail
    {
        public IList<Tarea2.Order_Detail> ConsultarDetalleOrdenPorNombreArticulo(string articulo)
        {
            var laAccion = new Tarea2.Logica.Acciones.Order_Detail();
            var elResultado = laAccion.ConsultarDetalleOrdenPorNombreArticulo(articulo);
            return elResultado;
        }

        public IList<Tarea2.Product> ConsultarDetalleOrdenPorNombreCategoria(string categoria)
        {
            var laAccion = new Tarea2.Logica.Acciones.Order_Detail();
            var elResultado = laAccion.ConsultarDetalleOrdenPorNombreCategoria(categoria);
            return elResultado;
        }

        public Tarea2.Order_Detail ConsultarPorId(int id)
        {
            var laAccion = new Tarea2.Logica.Acciones.Order_Detail();
            var elResultado = laAccion.ConsultarPorId(id);
            return elResultado;
        }


    }
}