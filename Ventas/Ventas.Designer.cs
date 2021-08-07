
namespace Ventas
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBD = new System.Windows.Forms.Label();
            this.labelCajero = new System.Windows.Forms.Label();
            this.labelFechaHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.labelCambio = new System.Windows.Forms.Label();
            this.textBoxPago = new System.Windows.Forms.TextBox();
            this.labelPago = new System.Windows.Forms.Label();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCaptura = new System.Windows.Forms.TextBox();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.buttonCancelarArticulo = new System.Windows.Forms.Button();
            this.buttonEliminarVenta = new System.Windows.Forms.Button();
            this.buttonGuardarVenta = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBD);
            this.panel1.Controls.Add(this.labelCajero);
            this.panel1.Controls.Add(this.labelFechaHora);
            this.panel1.Location = new System.Drawing.Point(827, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 100);
            this.panel1.TabIndex = 17;
            // 
            // labelBD
            // 
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBD.ForeColor = System.Drawing.Color.Blue;
            this.labelBD.Location = new System.Drawing.Point(3, 42);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(163, 16);
            this.labelBD.TabIndex = 11;
            this.labelBD.Text = "Base de datos en uso:";
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFolio);
            this.groupBox1.Controls.Add(this.textBoxCambio);
            this.groupBox1.Controls.Add(this.labelCambio);
            this.groupBox1.Controls.Add(this.textBoxPago);
            this.groupBox1.Controls.Add(this.labelPago);
            this.groupBox1.Controls.Add(this.buttonPagar);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Controls.Add(this.labelCantidad);
            this.groupBox1.Controls.Add(this.labelCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 127);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.Color.Blue;
            this.lblFolio.Location = new System.Drawing.Point(118, 14);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(47, 16);
            this.lblFolio.TabIndex = 28;
            this.lblFolio.Text = "Folio:";
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxCambio.Location = new System.Drawing.Point(651, 67);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.Size = new System.Drawing.Size(150, 44);
            this.textBoxCambio.TabIndex = 27;
            this.textBoxCambio.Visible = false;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.ForeColor = System.Drawing.Color.Blue;
            this.labelCambio.Location = new System.Drawing.Point(648, 48);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(65, 16);
            this.labelCambio.TabIndex = 26;
            this.labelCambio.Text = "Cambio:";
            this.labelCambio.Visible = false;
            // 
            // textBoxPago
            // 
            this.textBoxPago.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPago.Location = new System.Drawing.Point(545, 78);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(100, 31);
            this.textBoxPago.TabIndex = 24;
            this.textBoxPago.Visible = false;
            this.textBoxPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPago_KeyPress);
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.ForeColor = System.Drawing.Color.Blue;
            this.labelPago.Location = new System.Drawing.Point(542, 58);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(78, 16);
            this.labelPago.TabIndex = 25;
            this.labelPago.Text = "Paga con:";
            this.labelPago.Visible = false;
            // 
            // buttonPagar
            // 
            this.buttonPagar.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_payment_1954199;
            this.buttonPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.ForeColor = System.Drawing.Color.Blue;
            this.buttonPagar.Location = new System.Drawing.Point(461, 41);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(75, 70);
            this.buttonPagar.TabIndex = 22;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_search_magnifying_glass_find_103857;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.Blue;
            this.buttonBuscar.Location = new System.Drawing.Point(274, 41);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 70);
            this.buttonBuscar.TabIndex = 19;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(355, 78);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 31);
            this.textBoxCantidad.TabIndex = 20;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(118, 76);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(150, 31);
            this.textBoxCodigo.TabIndex = 18;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.Blue;
            this.labelCantidad.Location = new System.Drawing.Point(355, 58);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(70, 16);
            this.labelCantidad.TabIndex = 23;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.Blue;
            this.labelCodigo.Location = new System.Drawing.Point(118, 56);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(87, 16);
            this.labelCodigo.TabIndex = 21;
            this.labelCodigo.Text = "Id Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Id,
            this.Descripcion,
            this.PrecioUnitario,
            this.CategoriaId,
            this.Importe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 329);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBoxCaptura
            // 
            this.textBoxCaptura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaptura.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxCaptura.Location = new System.Drawing.Point(296, 514);
            this.textBoxCaptura.Name = "textBoxCaptura";
            this.textBoxCaptura.Size = new System.Drawing.Size(574, 44);
            this.textBoxCaptura.TabIndex = 29;
            this.textBoxCaptura.Text = "Teclee Numero de articulos *codigo";
            this.textBoxCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCaptura_KeyPress);
            this.textBoxCaptura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCaptura_KeyUp);
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIVA.Location = new System.Drawing.Point(1002, 462);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.Size = new System.Drawing.Size(150, 31);
            this.textBoxIVA.TabIndex = 25;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxTotal.Location = new System.Drawing.Point(1002, 520);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(180, 44);
            this.textBoxTotal.TabIndex = 24;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelTotal.Location = new System.Drawing.Point(924, 526);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(72, 25);
            this.labelTotal.TabIndex = 23;
            this.labelTotal.Text = "Total:";
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIVA.ForeColor = System.Drawing.Color.Blue;
            this.labelIVA.Location = new System.Drawing.Point(952, 477);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(44, 16);
            this.labelIVA.TabIndex = 22;
            this.labelIVA.Text = "I.V.A:";
            // 
            // buttonCancelarArticulo
            // 
            this.buttonCancelarArticulo.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_minus_1645995__1_;
            this.buttonCancelarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarArticulo.ForeColor = System.Drawing.Color.Yellow;
            this.buttonCancelarArticulo.Location = new System.Drawing.Point(209, 473);
            this.buttonCancelarArticulo.Name = "buttonCancelarArticulo";
            this.buttonCancelarArticulo.Size = new System.Drawing.Size(65, 85);
            this.buttonCancelarArticulo.TabIndex = 28;
            this.buttonCancelarArticulo.Text = "Cancelar Articulo";
            this.buttonCancelarArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelarArticulo.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarVenta
            // 
            this.buttonEliminarVenta.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_free_27_616650__2_;
            this.buttonEliminarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarVenta.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminarVenta.Location = new System.Drawing.Point(110, 473);
            this.buttonEliminarVenta.Name = "buttonEliminarVenta";
            this.buttonEliminarVenta.Size = new System.Drawing.Size(65, 85);
            this.buttonEliminarVenta.TabIndex = 27;
            this.buttonEliminarVenta.Text = "Eliminar";
            this.buttonEliminarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminarVenta.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarVenta
            // 
            this.buttonGuardarVenta.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_Save_1493294;
            this.buttonGuardarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarVenta.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonGuardarVenta.Location = new System.Drawing.Point(12, 473);
            this.buttonGuardarVenta.Name = "buttonGuardarVenta";
            this.buttonGuardarVenta.Size = new System.Drawing.Size(65, 85);
            this.buttonGuardarVenta.TabIndex = 26;
            this.buttonGuardarVenta.Text = "Guardar";
            this.buttonGuardarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardarVenta.UseVisualStyleBackColor = true;
            this.buttonGuardarVenta.Click += new System.EventHandler(this.buttonGuardarVenta_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // CategoriaId
            // 
            this.CategoriaId.HeaderText = "CategoriaId";
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.textBoxCaptura);
            this.Controls.Add(this.buttonCancelarArticulo);
            this.Controls.Add(this.buttonEliminarVenta);
            this.Controls.Add(this.buttonGuardarVenta);
            this.Controls.Add(this.textBoxIVA);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelIVA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Label labelCajero;
        private System.Windows.Forms.Label labelFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.TextBox textBoxPago;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCaptura;
        private System.Windows.Forms.Button buttonCancelarArticulo;
        private System.Windows.Forms.Button buttonEliminarVenta;
        private System.Windows.Forms.Button buttonGuardarVenta;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}