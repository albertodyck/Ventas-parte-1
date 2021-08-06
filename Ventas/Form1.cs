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
    public partial class Form1 : Form
    {
        public static string NombreUsuario = "";
        public Form1()
        {
            
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaNegocios.Empleado empleado = new LogicaNegocios.Empleado();

                string usuario = textBoxUser.Text;

                string contraseña = textBoxPassword.Text;

                if (empleado.Login(usuario, contraseña))
                {
                    //vaciamos el contenido del usuario a una variable a fin de llamarlo en el menu
                    NombreUsuario = usuario;

                    this.Hide();
                    new Menu().ShowDialog();
                    this.Show();

                    //MessageBox.Show("Conexion Satisfactoria");
                }
                else
                {
                    throw new Exception("Error de Conexión");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
