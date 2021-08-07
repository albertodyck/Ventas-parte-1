using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class VentaConcepto
    {
        public int Id { get; private set; }

        public int VentaId { get; set; }

        public int Renglon { get; set; }

        public int ProductoId { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Importe { get; set; }

        private readonly IBaseDeDatos baseDeDatos;

        public VentaConcepto(SeleccionBaseDeDatos.TipoBaseDeDatos tipoBaseDeDatos, string fuente)
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
                    query = "SELECT * FROM [VentaConceptos]";
                }
                else
                {
                    query = "SELECT * FROM [VentaConceptos$]";
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
                    query = "SELECT COUNT(*) FROM [VentaConceptos]";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM [VentaConceptos$]";
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
