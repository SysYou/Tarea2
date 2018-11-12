using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Repositorio
{
    public class Order_Detail
    {
        northwindEntities _contexto = new northwindEntities();

        public Order_Detail()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        internal IList<Tarea2.Order_Detail> ConsultarDetalleOrdenPorNombreArticulo(string articulo)
        {
            IList<Tarea2.Order_Detail> elResultado = _contexto.Order_Details.Include("Product").Where(c => c.Product.ProductName.Equals(articulo)).ToList();
            // LimpiarPropiedadesDeNavegacion(ref elResultado);
            return elResultado;
        }

        internal IList<Tarea2.Product> ConsultarDetalleOrdenPorNombreCategoria(string categoria)
        {
            IList<Tarea2.Product> elResultado = _contexto.Products.Include("Category").Where(c => c.Category.CategoryName.Equals(categoria)).ToList();
            // LimpiarPropiedadesDeNavegacion(ref elResultado);
            return elResultado;
        }
    }
}