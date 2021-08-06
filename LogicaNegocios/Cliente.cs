using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Cliente
    {
        string connectionString;

        public Cliente()
        {
            connectionString = "Server=localhost;Database=VENTAS_DB;Trusted_Connection=True;";
        }

        public DataTable ObtenerClientes()
        {
            try
            {
                SQL sql = new SQL(connectionString);

                string query = "SELECT * FROM [Clientes]";

                DataTable dtRespuesta = new DataTable();

                dtRespuesta = sql.ObtenerDataTable(query);

                return dtRespuesta;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public object Scalar()
        {
            try
            {
                SQL sql = new SQL(connectionString);

                string query = "SELECT COUNT(*) FROM [Clientes]";

                object resultado = sql.Scalar(query);

                return resultado;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int NonQuery(string query)
        {
            try
            {
                SQL sql = new SQL(connectionString);

                int resultado = sql.NonQuery(query);

                return resultado;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }

   
}
