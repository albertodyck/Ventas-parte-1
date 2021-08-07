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
        //string connectionString;

        private readonly IBaseDeDatos baseDeDatos;

        public Cliente(SeleccionBaseDeDatos.TipoBaseDeDatos tipoBaseDeDatos, string fuente)
        {
            baseDeDatos = SeleccionBaseDeDatos.Seleccionar(tipoBaseDeDatos, fuente);
        }


        public DataTable ObtenerClientes()
        {
            try
            {
                string query = "";
                if (baseDeDatos is SQL)
                {
                    query = "SELECT * FROM [Clientes]";
                }
                else
                {
                    query = "SELECT * FROM [Clientes$]";
                }

                DataTable dtRespuesta = new DataTable();

                dtRespuesta = baseDeDatos.ObtenerDataTable(query);

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
                string query = "";
                if (baseDeDatos is SQL)
                {
                    query = "SELECT COUNT(*) FROM [Clientes]";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM [Clientes$]";
                }

                object resultado = baseDeDatos.Scalar(query);

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

                int resultado = baseDeDatos.NonQuery(query);

                return resultado;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
