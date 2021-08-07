using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;

namespace Ventas
{
    public partial class CategoriasAdmin : Form
    {
        public CategoriasAdmin()
        {
            Categoria categoria = new Categoria(Global.TipoBaseDeDatos, Global.FuenteDeDatos);  

            InitializeComponent();

            txtId.ReadOnly = true;

        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                dgvDatos.DataSource = categoria.ObtenerCategorias();
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
                Categoria categoria = new Categoria(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    txtCategoria.Focus();
                    MessageBox.Show("El nombre de la categoria es requerido");
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    txtDescripcion.Focus();
                    MessageBox.Show("La descripcion de la categoria no debe estar vacia");
                }

                int.TryParse(categoria.Scalar().ToString(), out int CuentaContactos);

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = categoria.NonQuery($"INSERT INTO [Categorias] " +
                    $"(Categoria, Descripcion) VALUES " +
                    $"('{txtCategoria.Text}', '{txtDescripcion.Text}')");
                }
                else
                {
                    afectados = categoria.NonQuery($"INSERT INTO [Categorias$] " +
                    $"(Id, Categoria, Descripcion) VALUES " +
                    $"('{CuentaContactos + 1}', '{txtCategoria.Text}', '{txtDescripcion.Text}')");
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
            //    txtCategoria.Text = dgvDatos.Rows[renglon].Cells["Categoria"].Value.ToString();
            //    txtDescripcion.Text = dgvDatos.Rows[renglon].Cells["Descripcion"].Value.ToString();

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
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
                txtCategoria.Text = dgvDatos.Rows[renglon].Cells["Categoria"].Value.ToString();
                txtDescripcion.Text = dgvDatos.Rows[renglon].Cells["Descripcion"].Value.ToString();

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
                Categoria categoria = new Categoria(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    txtCategoria.Focus();
                    MessageBox.Show("El nombre de la categoria es requerido");
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    txtDescripcion.Focus();
                    MessageBox.Show("La descripcion de la categoria no debe estar vacia");
                }

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = categoria.NonQuery($"UPDATE [Categorias] " +
                    $" SET " +
                    $"Categoria = '{txtCategoria.Text}', " +
                    $"Descripcion = '{txtDescripcion.Text}' " + 
                    $"WHERE Id = {txtId.Text}");
                }
                else
                {
                    afectados = categoria.NonQuery($"UPDATE [Categorias$] " +
                    $" SET " +
                    $"Categoria = '{txtCategoria.Text}', " +
                    $"Descripcion = '{txtDescripcion.Text}' " +
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
                Categoria categoria = new Categoria(Global.TipoBaseDeDatos, Global.FuenteDeDatos);

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    throw new Exception("El id es requerido");
                }

                if (Global.TipoBaseDeDatos.ToString() == "SQL")
                {
                    afectados = categoria.NonQuery($"DELETE FROM [Categorias] " +
                    $"WHERE Id = {txtId.Text}");
                }
                else
                {
                    afectados = categoria.NonQuery($"DELETE FROM [Categorias$] " +
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


    }
}
