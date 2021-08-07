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
    public partial class ClientesAdmin : Form
    {
        private Cliente cliente;
        public ClientesAdmin()
        {
            cliente = new Cliente(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

            InitializeComponent();

            txtId.ReadOnly = true;
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                dgvDatos.DataSource = cliente.ObtenerClientes();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                int afectados = 0;

                Cliente cliente = new Cliente(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    txtCliente.Focus();
                    MessageBox.Show("El nombre del cliente es requerido");
                }

                int.TryParse(cliente.Scalar().ToString(), out int CuentaContactos);

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = cliente.NonQuery($"INSERT INTO [Clientes] " +
                    $"(Nombre) VALUES " +
                    $"('{txtCliente.Text}')");
                }
                else
                {
                    afectados = cliente.NonQuery($"INSERT INTO [Clientes$] " +
                    $"(Id, Nombre) VALUES " +
                    $"('{CuentaContactos + 1}', '{txtCliente.Text}')");
                }

                foreach (var control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Clear();
                    }
                }

                btnObtenerDatos.PerformClick();

                lblContactos.Text += $"   '{afectados}' registros afectados";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int renglon = e.RowIndex;
                if (renglon < 0)
                {
                    throw new Exception("No hay registros");
                }

                txtId.Text = dgvDatos.Rows[renglon].Cells["Id"].Value.ToString();
                txtCliente.Text = dgvDatos.Rows[renglon].Cells["Nombre"].Value.ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int afectados = 0;

                Cliente cliente = new Cliente(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    throw new Exception("El Id es requerido");
                }

                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    throw new Exception("El Nombre del cliente es requerido");
                }

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = cliente.NonQuery($"UPDATE [Clientes] " +
                    $" SET " +
                    $"Nombre = '{txtCliente.Text}' " +
                    $"WHERE Id = {txtId.Text}");
                }
                else
                {
                    afectados = cliente.NonQuery($"UPDATE [Clientes$] " +
                    $" SET " +
                    $"Nombre = '{txtCliente.Text}' " +
                    $"WHERE Id = {txtId.Text}");
                }

                foreach (var control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Clear();
                    }
                }

                btnObtenerDatos.PerformClick();

                lblContactos.Text += $"   '{afectados}' registros afectados";

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int afectados = 0;

                Cliente cliente = new Cliente(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    throw new Exception("El id es requerido");
                }

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = cliente.NonQuery($"DELETE FROM [Clientes] " +
                    $"WHERE Id = {txtId.Text}");
                }
                else
                {
                    afectados = cliente.NonQuery($"DELETE FROM [Clientes$] " +
                    $"WHERE Id = {txtId.Text}");
                }

                foreach (var control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Clear();
                    }
                }

                btnObtenerDatos.PerformClick();

                lblContactos.Text += $"   '{afectados}' registros afectados";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int renglon = e.RowIndex;
            //    if (renglon < 0)
            //    {
            //        throw new Exception("No hay registros");
            //    }

            //    txtId.Text = dgvDatos.Rows[renglon].Cells["Id"].Value.ToString();
            //    txtCliente.Text = dgvDatos.Rows[renglon].Cells["Nombre"].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

    }
}
