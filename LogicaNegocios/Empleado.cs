using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Empleado
    {
        string connectionString;
        public string NombreUsuario { get; set; }

        public Empleado()
        {
            connectionString = "Server=localhost;Database=VENTAS_DB;Trusted_Connection=True;";
        }

        public bool Login(string usuario, string contrasena)
        {
            try
            {
                SQL sql = new SQL(connectionString);

                string query = $"SELECT COUNT(*) FROM EMPLEADOS WHERE Nombre='{usuario}' AND Contrasena = '{contrasena}'";

                string ejecutar = sql.Scalar(query).ToString();

                int encontrado = 0;

                int.TryParse(ejecutar, out encontrado);
                //login exitoso
                if (encontrado > 0)
                {
                    return true;
                }
                else
                //no acceso
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
