using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Class1
    {
        string conectionString;
        public Class1()
        {
            conectionString = "Server=localhost;Database=VENTAS_DB;Trusted_Connection=True;";
        }

        public bool Conexion()
        {
            SQL sql = new SQL(conectionString);

            return sql.ProbarConexion();
        }

    }
}
