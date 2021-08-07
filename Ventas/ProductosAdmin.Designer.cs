
namespace Ventas
{
    partial class ProductosAdmin
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
            this.btnObtenerDatos = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblContactos = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblCategoriaId = new System.Windows.Forms.Label();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.buttonAgregarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtenerDatos
            // 
            this.btnObtenerDatos.Location = new System.Drawing.Point(158, 174);
            this.btnObtenerDatos.Name = "btnObtenerDatos";
            this.btnObtenerDatos.Size = new System.Drawing.Size(162, 23);
            this.btnObtenerDatos.TabIndex = 28;
            this.btnObtenerDatos.Text = "Obtener datos";
            this.btnObtenerDatos.UseVisualStyleBackColor = true;
            this.btnObtenerDatos.Click += new System.EventHandler(this.btnObtenerDatos_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(408, 101);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(61, 34);
            this.btnBorrar.TabIndex = 25;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(408, 61);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(61, 34);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(408, 21);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(61, 34);
            this.btnNuevoRegistro.TabIndex = 27;
            this.btnNuevoRegistro.Text = "Nuevo";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(17, 203);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(453, 209);
            this.dgvDatos.TabIndex = 24;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Location = new System.Drawing.Point(17, 302);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(13, 13);
            this.lblContactos.TabIndex = 21;
            this.lblContactos.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(59, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Id";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(31, 60);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 23;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 20);
            this.txtId.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(113, 57);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(258, 20);
            this.txtDescripcion.TabIndex = 20;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(31, 86);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioUnitario.TabIndex = 30;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(113, 83);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(258, 20);
            this.txtPrecioUnitario.TabIndex = 29;
            // 
            // lblCategoriaId
            // 
            this.lblCategoriaId.AutoSize = true;
            this.lblCategoriaId.Location = new System.Drawing.Point(31, 112);
            this.lblCategoriaId.Name = "lblCategoriaId";
            this.lblCategoriaId.Size = new System.Drawing.Size(64, 13);
            this.lblCategoriaId.TabIndex = 32;
            this.lblCategoriaId.Text = "Categoria Id";
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Location = new System.Drawing.Point(113, 109);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.Size = new System.Drawing.Size(258, 20);
            this.txtCategoriaId.TabIndex = 31;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(31, 138);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 34;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(113, 138);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(258, 21);
            this.cmbCategoria.TabIndex = 35;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // buttonAgregarCategoria
            // 
            this.buttonAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCategoria.Location = new System.Drawing.Point(377, 136);
            this.buttonAgregarCategoria.Name = "buttonAgregarCategoria";
            this.buttonAgregarCategoria.Size = new System.Drawing.Size(23, 23);
            this.buttonAgregarCategoria.TabIndex = 36;
            this.buttonAgregarCategoria.Text = "+";
            this.buttonAgregarCategoria.UseVisualStyleBackColor = true;
            this.buttonAgregarCategoria.Click += new System.EventHandler(this.buttonAgregarCategoria_Click);
            // 
            // ProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 449);
            this.Controls.Add(this.buttonAgregarCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCategoriaId);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.btnObtenerDatos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblContactos);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "ProductosAdmin";
            this.Text = "ProductosAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerDatos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblCategoriaId;
        private System.Windows.Forms.TextBox txtCategoriaId;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button buttonAgregarCategoria;
    }
}