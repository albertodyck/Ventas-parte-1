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
        public int productoId { get; set; }

        public string descripcion { get; set; }

        public decimal precioUnitario { get; set; }

        public int categoriaId { get; set; }

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


    }
}
