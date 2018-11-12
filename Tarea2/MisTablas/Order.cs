using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tarea2
{
    public partial class Order
    {

        public int? Demora
        {
            get
            {
                int? Demora = null;
                //SELECT DATEDIFF(day, [OrderDate], [ShippedDate]) AS 'Duration' from Orders


                Demora = (int)((DateTime)OrderDate - (DateTime)ShippedDate).TotalDays;

                return Demora;
            }
        }


        //public String? Concatenar
        //{
        //    get
        //    {
        //        String? Concatenar;
        //        //

        //        string employee = EmployeeID.ToString();
        //        string ship = ShipVia.ToString();

        //        Concatenar = String.Join(CustomerID, employee, ship);

        //        return Concatenar;
        //    }
        //}

    }
}