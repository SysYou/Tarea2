using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tarea2
{
    public partial class Order_Detail
    {

        public int? Bruto
        {
            get
            {
                int? Bruto = null;
                //[UnitPrice] * [Quantity]  as Total
                Bruto = (int)(UnitPrice * Quantity);
                return Bruto;
            }
        }

        public int? Monto_Descuento

        {
            get
            {
                int? MontoDescuento = null;
                //([UnitPrice] * [Quantity] * [Discount]) / 100 as MontoDescuento
                MontoDescuento = Convert.ToInt32(Bruto * Discount) / 100;
                return Monto_Descuento;
            }
        }

        public int? Neto

        {
            get
            {
                int? Neto = null;
                Neto = Convert.ToInt32(Bruto - Monto_Descuento);
                return Neto;
            }
        }

    }
    
}