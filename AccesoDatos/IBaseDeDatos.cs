using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    //una interfaz es un contrato, de definiciones sin cuerpo ni propiedades
    //Contrato significa la clase que implemente esta interfaz debera implementar estos metodos
    //todos aquellos que implementan una interfaz son compatibles
    public interface IBaseDeDatos
    {
        string ConnectionString { get; }
        bool ProbarConexion();

        object Scalar(string query);

        int NonQuery(string query);

        Dictionary<string, object> Reader(string query);

        DataTable ObtenerDataTable(string query);

        object Scalar(SqlCommand sqlCommand, SqlTransaction sqlTransaction);

        int NonQuery(SqlCommand sqlCommand, SqlTransaction sqlTransaction);

    }
}
