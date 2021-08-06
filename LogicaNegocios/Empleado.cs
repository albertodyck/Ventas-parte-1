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
        //string connectionString;
        public int Id { get; set; }
        public string Nombre { get; set; }

        private readonly IBaseDeDatos baseDeDatos;

        //public Empleado()
        //{
        //    connectionString = "Server=localhost;Database=VENTAS_DB;Trusted_Connection=True;";
        //}

        public Empleado(SeleccionBaseDeDatos.TipoBaseDeDatos tipoBaseDeDatos, string fuente)
        {
            baseDeDatos = SeleccionBaseDeDatos.Seleccionar(tipoBaseDeDatos, fuente);
        }

        public void Login(string usuario, string contrasena)
        {
            try
            {
                //SQL sql = new SQL(connectionString);
                string query = "";
                if (baseDeDatos is SQL)
                {
                    query = $"SELECT Id, Nombre FROM EMPLEADOS WHERE Nombre='{usuario}' AND Contrasena = '{contrasena}'";
                }
                else
                {
                    query = $"SELECT Id, Nombre FROM [EMPLEADOS$] WHERE Nombre='{usuario}' AND Contrasena = '{contrasena}'";
                }

                //se trae dos columnas de un renglon en un reader y los coloca en un diccionario
                Dictionary<string, object> dicEmpleado = baseDeDatos.Reader(query);

                //Nueva validacion de empleado encontrado:

                if (dicEmpleado.Count < 1)
                {
                    throw new Exception("Usuario y/o contraseña incorrectos");
                }

                //Se trae el Id y lo convierte a entero si viene de excel, si viene de SQL ya es Int y lo guarda en usuarioId
                int.TryParse(dicEmpleado["Id"].ToString(), out int usuarioId);

                Id = usuarioId;

                Nombre = dicEmpleado["Nombre"].ToString();


                //int encontrado = 0;
                //int.TryParse(ejecutar, out encontrado);
                ////login exitoso
                //if (encontrado > 0)
                //{
                //    return true;
                //}
                //else
                ////no acceso
                //{
                //    return false;
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
