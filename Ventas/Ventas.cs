using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Ventas : Form
    {
        float total = 0;
        float IVA = 0;
        //int Folio = 0;
        //DataTable Renglon = new DataTable();
        float ImporteRengon = 0;

        public Ventas()
        {
            Venta venta = new Venta(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

            VentaConcepto ventaConcepto = new VentaConcepto(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            //colocar el nombre del cajero en una etiqueta y la fecha y hora
            labelCajero.Text = $"UsuarioId: {Global.Usuarioid} Nombre: {Global.NombreUsuario}";
            labelBD.Text = $"Esta usando {Global.TipoBaseDeDatos} como base de datos";

            //#region Folio

            ////obtener el folio de la venta
            //Folio folio = new Folio(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

            //try
            //{
            //    int.TryParse(folio.Scalar().ToString(), out int CuentaFolios);

            //    Folio = CuentaFolios + 1;

            //    lblFolio.Text = $"Folio: {Folio}";
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //#endregion


            Invisibles();

            //Distribuir columnas de datagrid
            dataGridView1.Columns[0].Width = dataGridView1.Width * 10 / 100;
            dataGridView1.Columns[1].Width = dataGridView1.Width * 10 / 100;
            dataGridView1.Columns[2].Width = dataGridView1.Width * 35 / 100;
            dataGridView1.Columns[3].Width = dataGridView1.Width * 15 / 100;
            dataGridView1.Columns[4].Width = dataGridView1.Width * 15 / 100;
            dataGridView1.Columns[5].Width = dataGridView1.Width * 15 / 100;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Invisibles()
        {
            labelPago.Visible = false;
            textBoxPago.Visible = false;
            textBoxPago.Clear();
            textBoxCambio.Visible = false;
            textBoxCambio.Clear();
            labelCambio.Visible = false;
            textBoxIVA.Clear();
            textBoxTotal.Clear();
            textBoxCantidad.Clear();
            textBoxCodigo.Clear();

        }

        #region funcion limpiar cuadros de texto
        private void BorrarTexto(TextBox textbox)
        {
            textbox.Text = "";
        }
        #endregion

        //validacion en codigo solo numeros
        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)(Keys.Enter))
            {
                //e.Handled = true;
                textBoxCantidad.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }

        //validacion en cantidad, solo numeros y si es enter regresar a codigo
        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)(Keys.Enter))
            {
                //e.Handled = true;

                try
                {
                    Producto producto = new Producto(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                    DataRow Renglon = producto.ObtenerProducto(int.Parse(textBoxCodigo.Text)).Rows[0];

                    ImporteRengon = int.Parse(textBoxCantidad.Text) * float.Parse(Renglon["PrecioUnitario"].ToString());

                    dataGridView1.Rows.Add(textBoxCantidad.Text, textBoxCodigo.Text, Renglon["Descripcion"].ToString(), Renglon["PrecioUnitario"].ToString(), Renglon["CategoriaId"].ToString(), ImporteRengon);

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                //enviar renglon al datagrid

                //dataGridView1.Rows.Add(textBoxCantidad.Text, textBoxCodigo.Text, Renglon.Rows[1][1].ToString(), Renglon.Rows[1][2].ToString(), Renglon.Rows[1][3].ToString(), ImporteRengon);

                BorrarTexto(textBoxCodigo);
                BorrarTexto(textBoxCantidad);
                textBoxCodigo.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }

        //hace visibles la etiqueta
        private void buttonPagar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

            venta.GuardarVenta(venta);

            labelPago.Visible = true;
            textBoxPago.Visible = true;
            textBoxPago.Focus();
        }

        //validacion solo numeros en cantidad de pago
        private void textBoxPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (true)
            {
                textBoxCambio.Visible = true;
                labelCambio.Visible = true;
                textBoxCambio.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }
        //modificar 
        private void textBoxCaptura_KeyPress(object sender, KeyPressEventArgs e)
        {
            string query;
            string cantidad;
            string codigo;



            if (e.KeyChar == 13 && textBoxCaptura.Text != "")
            {
                if (textBoxCaptura.Text.IndexOf("*") == -1)
                {
                    query = "SELECT * FROM productos WHERE Codigo=" + textBoxCaptura.Text;

                    codigo = textBoxCaptura.Text;
                    textBoxCodigo.Text = codigo;
                    cantidad = "1";
                    textBoxCantidad.Text = cantidad;
                }
                else
                {
                    string[] cantidad_producto = textBoxCaptura.Text.Split('*');

                    query = "SELECT * FROM productos WHERE Codigo=" + cantidad_producto[1];

                    cantidad = cantidad_producto[0];
                    codigo = cantidad_producto[1];
                    textBoxCodigo.Text = codigo;
                    textBoxCantidad.Text = cantidad;

                }

                //conexion bd
                //MySqlConnection mySqlConnection = new MySqlConnection("server = localhost; user=root;database=puntodeventa;");
                //mySqlConnection.Open();
                //MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                //MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                //llenar datagrid con base de datos

                //while (mySqlDataReader.Read())
                //{
                //    float qty = float.Parse(cantidad);
                //    //cantidad por precio en bd
                //    float totalLinea = qty * mySqlDataReader.GetFloat(3);
                //    float iva_venta = totalLinea * 16 / 100;
                //    IVA = IVA + iva_venta;

                //    dataGridView1.Rows.Add(cantidad, codigo, mySqlDataReader.GetString(2), mySqlDataReader.GetInt16(1), mySqlDataReader.GetFloat(3), string.Format("{0:.##}", totalLinea));
                //}

                textBoxCaptura.Clear();
                textBoxCaptura.Focus();

                //calculo de total y despliegue en textbox

                total = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total += float.Parse(dataGridView1[5, i].Value.ToString());
                }

                textBoxIVA.Text = "$" + string.Format("{0:.##}", IVA);
                textBoxTotal.Text = "$" + string.Format("{0:.##}", total);
            }
        }

        //modificar
        private void textBoxCaptura_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                float pago = float.Parse(textBoxCaptura.Text.Remove(textBoxCaptura.TextLength - 1));

                textBoxPago.Visible = true;
                labelPago.Visible = true;
                textBoxPago.Text = "$" + pago;

                labelCambio.Visible = true;
                textBoxCambio.Visible = true;
                textBoxCambio.Text = "$" + (pago - total);

                textBoxCaptura.Focus();
                textBoxCaptura.Clear();

                //limpiar el datagrid
                dataGridView1.Rows.Clear();

                buttonGuardarVenta.Focus();
            }
        }

        private void buttonGuardarVenta_Click(object sender, EventArgs e)
        {


            //reiniciar 
            Invisibles();
            IVA = 0;
            total = 0;
            textBoxCaptura.Focus();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
