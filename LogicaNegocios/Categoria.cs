using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Categoria
    {

        private readonly IBaseDeDatos baseDeDatos;

        public Categoria(SeleccionBaseDeDatos.TipoBaseDeDatos tipoBaseDeDatos, string fuente)
        {
            baseDeDatos = SeleccionBaseDeDatos.Seleccionar(tipoBaseDeDatos, fuente);
        }

        public DataTable ObtenerCategorias()
        {
            try
            {
                string query = "";
                if (baseDeDatos is SQL)
                {
                    query = "SELECT * FROM [Categorias]";
                }
                else
                {
                    query = "SELECT * FROM [Categorias$]";
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
                    query = "SELECT COUNT(*) FROM [Categorias]";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM [Categorias$]";
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
