
namespace Ventas
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCajero = new System.Windows.Forms.Label();
            this.labelFechaHora = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.puntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarPuntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloDeAdministracionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClientAdmin = new System.Windows.Forms.Button();
            this.buttonUserAdmin = new System.Windows.Forms.Button();
            this.buttonPuntoVenta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelBD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBD);
            this.panel1.Controls.Add(this.labelCajero);
            this.panel1.Controls.Add(this.labelFechaHora);
            this.panel1.Location = new System.Drawing.Point(12, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 100);
            this.panel1.TabIndex = 16;
            // 
            // labelCajero
            // 
            this.labelCajero.AutoSize = true;
            this.labelCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCajero.ForeColor = System.Drawing.Color.Blue;
            this.labelCajero.Location = new System.Drawing.Point(3, 14);
            this.labelCajero.Name = "labelCajero";
            this.labelCajero.Size = new System.Drawing.Size(70, 16);
            this.labelCajero.TabIndex = 10;
            this.labelCajero.Text = "Usuario: ";
            this.labelCajero.Click += new System.EventHandler(this.labelCajero_Click);
            // 
            // labelFechaHora
            // 
            this.labelFechaHora.AutoSize = true;
            this.labelFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHora.ForeColor = System.Drawing.Color.Blue;
            this.labelFechaHora.Location = new System.Drawing.Point(3, 73);
            this.labelFechaHora.Name = "labelFechaHora";
            this.labelFechaHora.Size = new System.Drawing.Size(89, 16);
            this.labelFechaHora.TabIndex = 9;
            this.labelFechaHora.Text = "Fecha,Hora";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoDeVentaToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            this.puntoDeVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarPuntoDeVentaToolStripMenuItem});
            this.puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            this.puntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.puntoDeVentaToolStripMenuItem.Text = "Punto de Venta";
            // 
            // ejecutarPuntoDeVentaToolStripMenuItem
            // 
            this.ejecutarPuntoDeVentaToolStripMenuItem.Name = "ejecutarPuntoDeVentaToolStripMenuItem";
            this.ejecutarPuntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ejecutarPuntoDeVentaToolStripMenuItem.Text = "Ejecutar punto de venta";
            this.ejecutarPuntoDeVentaToolStripMenuItem.Click += new System.EventHandler(this.ejecutarPuntoDeVentaToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloDeAdministracionDeUsuariosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.administraciónToolStripMenuItem.Text = "Administración de Usuarios";
            // 
            // moduloDeAdministracionDeUsuariosToolStripMenuItem
            // 
            this.moduloDeAdministracionDeUsuariosToolStripMenuItem.Name = "moduloDeAdministracionDeUsuariosToolStripMenuItem";
            this.moduloDeAdministracionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.moduloDeAdministracionDeUsuariosToolStripMenuItem.Text = "Modulo de Administracion de Usuarios";
            this.moduloDeAdministracionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.moduloDeAdministracionDeUsuariosToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.Productos,
            this.categoriaDeProductosToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(172, 20);
            this.administracionToolStripMenuItem.Text = "Administracion de Catalogos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Productos
            // 
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(198, 22);
            this.Productos.Text = "Productos";
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // categoriaDeProductosToolStripMenuItem
            // 
            this.categoriaDeProductosToolStripMenuItem.Name = "categoriaDeProductosToolStripMenuItem";
            this.categoriaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.categoriaDeProductosToolStripMenuItem.Text = "Categoria de Productos";
            this.categoriaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.categoriaDeProductosToolStripMenuItem_Click);
            // 
            // buttonClientAdmin
            // 
            this.buttonClientAdmin.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_040_95876;
            this.buttonClientAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClientAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientAdmin.ForeColor = System.Drawing.Color.Blue;
            this.buttonClientAdmin.Location = new System.Drawing.Point(329, 47);
            this.buttonClientAdmin.Name = "buttonClientAdmin";
            this.buttonClientAdmin.Size = new System.Drawing.Size(110, 165);
            this.buttonClientAdmin.TabIndex = 19;
            this.buttonClientAdmin.Text = "Administracion de Clientes";
            this.buttonClientAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClientAdmin.UseVisualStyleBackColor = true;
            this.buttonClientAdmin.Click += new System.EventHandler(this.buttonClientAdmin_Click);
            // 
            // buttonUserAdmin
            // 
            this.buttonUserAdmin.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_Facebook_UI_31_2344305;
            this.buttonUserAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserAdmin.ForeColor = System.Drawing.Color.Blue;
            this.buttonUserAdmin.Location = new System.Drawing.Point(174, 47);
            this.buttonUserAdmin.Name = "buttonUserAdmin";
            this.buttonUserAdmin.Size = new System.Drawing.Size(110, 165);
            this.buttonUserAdmin.TabIndex = 18;
            this.buttonUserAdmin.Text = "Administracion de Usuarios";
            this.buttonUserAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUserAdmin.UseVisualStyleBackColor = true;
            this.buttonUserAdmin.Click += new System.EventHandler(this.buttonUserAdmin_Click);
            // 
            // buttonPuntoVenta
            // 
            this.buttonPuntoVenta.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_24_Cash_Register_29248371;
            this.buttonPuntoVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPuntoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPuntoVenta.ForeColor = System.Drawing.Color.Blue;
            this.buttonPuntoVenta.Location = new System.Drawing.Point(18, 47);
            this.buttonPuntoVenta.Name = "buttonPuntoVenta";
            this.buttonPuntoVenta.Size = new System.Drawing.Size(110, 165);
            this.buttonPuntoVenta.TabIndex = 17;
            this.buttonPuntoVenta.Text = "Punto de Venta";
            this.buttonPuntoVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPuntoVenta.UseVisualStyleBackColor = true;
            this.buttonPuntoVenta.Click += new System.EventHandler(this.buttonPuntoVenta_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelBD
            // 
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBD.ForeColor = System.Drawing.Color.Blue;
            this.labelBD.Location = new System.Drawing.Point(3, 47);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(163, 16);
            this.labelBD.TabIndex = 11;
            this.labelBD.Text = "Base de datos en uso:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 342);
            this.Controls.Add(this.buttonClientAdmin);
            this.Controls.Add(this.buttonUserAdmin);
            this.Controls.Add(this.buttonPuntoVenta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClientAdmin;
        private System.Windows.Forms.Button buttonUserAdmin;
        private System.Windows.Forms.Button buttonPuntoVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCajero;
        private System.Windows.Forms.Label labelFechaHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarPuntoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloDeAdministracionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaDeProductosToolStripMenuItem;
        private System.Windows.Forms.Label labelBD;
    }
}