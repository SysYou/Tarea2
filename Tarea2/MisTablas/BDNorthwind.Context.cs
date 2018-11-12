using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.MisTablas
{
    public partial class northwindEntities : DbContext
    {

        public northwindEntities(string myConnectionString)

        {
            this.Database.Connection.ConnectionString = myConnectionString;
        }

    }
}