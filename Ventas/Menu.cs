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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            labelCajero.Text = $"UsuarioId: {Global.Usuarioid} Nombre: {Global.NombreUsuario}";
            labelBD.Text = $"Esta usando {Global.TipoBaseDeDatos} como base de datos";
        }

        private void labelCajero_Click(object sender, EventArgs e)
        {

        }

        private void buttonPuntoVenta_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ejecutarPuntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moduloDeAdministracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductosAdmin().ShowDialog();
            this.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientesAdmin().ShowDialog();
            this.Show();
        }

        private void categoriaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategoriasAdmin().ShowDialog();
            this.Show();
        }

        private void buttonClientAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientesAdmin().ShowDialog();
            this.Show();
        }

        private void buttonProductosAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductosAdmin().ShowDialog();
            this.Show();
        }

        private void buttonAdminCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategoriasAdmin().ShowDialog();
            this.Show();
        }
    }
}
