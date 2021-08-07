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
    public partial class ProductosAdmin : Form
    {
        public ProductosAdmin()
        {
            Producto producto = new Producto(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

            Categoria categoria = new Categoria(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

            InitializeComponent();

            txtId.ReadOnly = true;
            txtCategoriaId.ReadOnly = true;

            //llenar el combobox con un droplist de la tabla categoria, usando la funcion creada y la interfase
            
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.DataSource = categoria.ObtenerCategorias();

            //mostrar en textbox el id de la categoria

            txtCategoriaId.Text = Convert.ToString(cmbCategoria.SelectedValue);

            //txtCategoriaId.Text = cmbCategoria.ValueMember;
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                dgvDatos.DataSource = producto.ObtenerProductos();
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
                Producto producto = new Producto(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    txtDescripcion.Focus();
                    MessageBox.Show("La descripcion del Producto es requerida");
                }

                if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
                {
                    txtPrecioUnitario.Focus();
                    MessageBox.Show("El precio del Producto es requerido");
                }

                if (string.IsNullOrWhiteSpace(txtCategoriaId.Text))
                {
                    txtCategoriaId.Focus();
                    MessageBox.Show("El codigo de la categoria es requerido");
                }

                int.TryParse(producto.Scalar().ToString(), out int CuentaContactos);

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = producto.NonQuery($"INSERT INTO [Productos] " +
                    $"(Descripcion, PrecioUnitario, CategoriaId) VALUES " +
                    $"('{txtDescripcion.Text}', '{txtPrecioUnitario.Text}', '{txtCategoriaId.Text}')");
                }
                else
                {
                    afectados = producto.NonQuery($"INSERT INTO [Productos$] " +
                    $"(Id, Descripcion, PrecioUnitario, CategoriaId) VALUES " +
                    $"('{CuentaContactos + 1}', '{txtDescripcion.Text}', '{txtPrecioUnitario.Text}', '{txtCategoriaId.Text}')");
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

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int renglon = e.RowIndex;
            //    if (renglon < 0)
            //    {
            //        throw new Exception("No hay registros");
            //    }

            //    txtId.Text = dgvDatos.Rows[renglon].Cells["Id"].Value.ToString();
            //    txtDescripcion.Text = dgvDatos.Rows[renglon].Cells["Descripcion"].Value.ToString();
            //    txtPrecioUnitario.Text = dgvDatos.Rows[renglon].Cells["PrecioUnitario"].Value.ToString();
            //    txtCategoriaId.Text = dgvDatos.Rows[renglon].Cells["CategoriaId"].Value.ToString();

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int afectados = 0;
                Producto producto = new Producto(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    txtDescripcion.Focus();
                    MessageBox.Show("La descripcion del Producto es requerida");
                }

                if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
                {
                    txtPrecioUnitario.Focus();
                    MessageBox.Show("El precio del Producto es requerido");
                }

                if (string.IsNullOrWhiteSpace(txtCategoriaId.Text))
                {
                    txtCategoriaId.Focus();
                    MessageBox.Show("El codigo de la categoria es requerido");
                }

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = producto.NonQuery($"UPDATE [Productos] " +
                    $" SET " +
                    $"Descripcion = '{txtDescripcion.Text}', " +
                    $"PrecioUnitario = '{txtPrecioUnitario.Text}', " +
                    $"CategoriaId = '{txtCategoriaId.Text}' " +
                    $"WHERE Id = {txtId.Text}");
                }
                else
                {
                    afectados = producto.NonQuery($"UPDATE [Productos$] " +
                    $" SET " +
                    $"Descripcion = '{txtDescripcion.Text}', " +
                    $"PrecioUnitario = '{txtPrecioUnitario.Text}', " +
                    $"CategoriaId = '{txtCategoriaId.Text}' " +
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
                Producto producto = new Producto(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    throw new Exception("El id es requerido");
                }

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = producto.NonQuery($"DELETE FROM [Productos] " +
                    $"WHERE Id = {txtId.Text}");
                }
                else
                {
                    afectados = producto.NonQuery($"DELETE FROM [Productos$] " +
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


        private void buttonAgregarCategoria_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new CategoriasAdmin().ShowDialog();
            this.Show();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategoriaId.Text = Convert.ToString(cmbCategoria.SelectedValue);
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int renglon = e.RowIndex;
                if (renglon < 0)
                {
                    throw new Exception("No hay registros");
                }

                txtId.Text = dgvDatos.Rows[renglon].Cells["Id"].Value.ToString();
                txtDescripcion.Text = dgvDatos.Rows[renglon].Cells["Descripcion"].Value.ToString();
                txtPrecioUnitario.Text = dgvDatos.Rows[renglon].Cells["PrecioUnitario"].Value.ToString();
                txtCategoriaId.Text = dgvDatos.Rows[renglon].Cells["CategoriaId"].Value.ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)//digitos o back space
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
