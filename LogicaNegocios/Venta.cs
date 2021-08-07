using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Venta
    {
        public int Id { get; private set; }

        public int Folio { get; set; }

        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }

        public int EmpleadoId { get; set; }

        public decimal Total { get; set; }

        public List<VentaConcepto> Conceptos { get; set; }

        private readonly IBaseDeDatos baseDeDatos;

        public Venta(SeleccionBaseDeDatos.TipoBaseDeDatos tipoBaseDeDatos, string fuente)
        {
            baseDeDatos = SeleccionBaseDeDatos.Seleccionar(tipoBaseDeDatos, fuente);

            Conceptos = new List<VentaConcepto>();
        }

        public DataTable ObtenerProductos()
        {
            try
            {
                string query = "";
                if (baseDeDatos is SQL)
                {
                    query = "SELECT * FROM [Ventas]";
                }
                else
                {
                    query = "SELECT * FROM [Ventas$]";
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
                    query = "SELECT COUNT(*) FROM [Ventas]";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM [Ventas$]";
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

        public int GuardarVenta(Venta venta)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(baseDeDatos.ConnectionString))
                {
                    SqlTransaction sqlTransaction;

                    sqlConnection.Open();

                    sqlTransaction = sqlConnection.BeginTransaction();

                    try
                    {
                        venta.Folio = ObtenerFolio(sqlConnection, sqlTransaction);

                        venta.Fecha = DateTime.Now;

                        venta.Id = InsertarVenta(sqlConnection, sqlTransaction, venta);

                        foreach (VentaConcepto concepto in venta.Conceptos)
                        {
                            concepto.VentaId = venta.Id;

                            InsertarVentaConcepto(sqlConnection, sqlTransaction, concepto);
                        }

                        IncrementarFolio(sqlConnection, sqlTransaction);

                        sqlTransaction.Commit();

                        return venta.Id;
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }

                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int ObtenerFolio(SqlConnection sqlConnection, SqlTransaction sqlTransaction)
        {
            try
            {
                string query = "SELECT [FOLIO] FROM [FOLIOS]";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    return Convert.ToInt32(baseDeDatos.Scalar(sqlCommand, sqlTransaction));
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int IncrementarFolio(SqlConnection sqlConnection, SqlTransaction sqlTransaction)
        {
            try
            {
                string query = "UPDATE [FOLIOS] SET [FOLIO] = [FOLIO] + 1";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    return Convert.ToInt32(baseDeDatos.Scalar(sqlCommand, sqlTransaction));
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int InsertarVenta(SqlConnection sqlConnection, SqlTransaction sqlTransaction, Venta venta)
        {
            try
            {
                string query ="";

                query += "INSERT INTO [Ventas]";
                query += "           ([Folio]";
                query += "           ,[Fecha]";
                query += "           ,[ClienteId]";
                query += "           ,[EmpleadoId]";
                query += "           ,[Total])";
                query += "     VALUES";
                query += "           (@Folio ";
                query += "           ,@Fecha";
                query += "           ,@ClienteId";
                query += "           ,@EmpleadoId";
                query += "           ,@Total);SELECT COALESCE(SCOPE_IDENTITY(), 0) as Id";



                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.Parameters.AddWithValue("@Folio", venta.Folio);
                    sqlCommand.Parameters.AddWithValue("@Fecha", venta.Fecha);
                    sqlCommand.Parameters.AddWithValue("@ClienteId", venta.ClienteId);
                    sqlCommand.Parameters.AddWithValue("@EmpleadoId", venta.EmpleadoId);
                    sqlCommand.Parameters.AddWithValue("@Total", venta.Total);

                    return Convert.ToInt32(baseDeDatos.Scalar(sqlCommand, sqlTransaction));
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int InsertarVentaConcepto(SqlConnection sqlConnection, SqlTransaction sqlTransaction, VentaConcepto concepto)
        {
            try
            {
                string query = "";

                query += "INSERT INTO [VentaConceptos]";
                query += "  ([VentaId]";
                query += "  ,[Renglon]";
                query += "  ,[ProductoId]";
                query += "  ,[Cantidad]";
                query += "  ,[PrecioUnitario]";
                query += "  ,[Importe])";
                query += " VALUES";
                query += "  (@VentaId,";
                query += "  @Renglon,";
                query += "  @ProductoId,";
                query += "  @Cantidad,";
                query += "  @PrecioUnitario,";
                query += "  @Importe);SELECT COALESCE(SCOPE_IDENTITY(), 0) as Id";


                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.Parameters.AddWithValue("@VentaId", concepto.VentaId);
                    sqlCommand.Parameters.AddWithValue("@Renglon", concepto.Renglon);
                    sqlCommand.Parameters.AddWithValue("@ProductoId", concepto.ProductoId);
                    sqlCommand.Parameters.AddWithValue("@Cantidad", concepto.Cantidad);
                    sqlCommand.Parameters.AddWithValue("@PrecioUnitario", concepto.PrecioUnitario);
                    sqlCommand.Parameters.AddWithValue("@Importe", concepto.Importe);

                    return Convert.ToInt32(baseDeDatos.Scalar(sqlCommand, sqlTransaction));
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
