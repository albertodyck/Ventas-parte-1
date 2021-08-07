using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Producto
    {
        //propiedades llevan mayuscula al inicio
        public int ProductoId { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int CategoriaId { get; set; }

        private readonly IBaseDeDatos baseDeDatos;

        public Producto(SeleccionBaseDeDatos.TipoBaseDeDatos tipoBaseDeDatos, string fuente)
        {
            baseDeDatos = SeleccionBaseDeDatos.Seleccionar(tipoBaseDeDatos, fuente);
        }

        public DataTable ObtenerProductos()
        {
            try
            {
                string query = "";
                if (baseDeDatos is SQL)
                {
                    query = "SELECT * FROM [Productos]";
                }
                else
                {
                    query = "SELECT * FROM [Productos$]";
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

        public DataTable ObtenerProducto(int id)
        {
            try
            {
                string query = "";
                if (baseDeDatos is SQL)
                {
                    query = $"SELECT * FROM [Productos] WHERE Id={id}";
                }
                else
                {
                    query = $"SELECT * FROM [Productos$] WHERE Id={id}";
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
                    query = "SELECT COUNT(*) FROM [Productos]";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM [Productos$]";
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
