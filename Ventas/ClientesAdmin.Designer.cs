
namespace Ventas
{
    partial class ClientesAdmin
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblContactos = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnObtenerDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(408, 101);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(61, 34);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(408, 61);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(61, 34);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(408, 21);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(61, 34);
            this.btnNuevoRegistro.TabIndex = 17;
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
            this.dgvDatos.Location = new System.Drawing.Point(17, 140);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(453, 159);
            this.dgvDatos.TabIndex = 14;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Location = new System.Drawing.Point(17, 302);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(13, 13);
            this.lblContactos.TabIndex = 11;
            this.lblContactos.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(59, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cliente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(92, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(279, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(92, 57);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(279, 20);
            this.txtCliente.TabIndex = 8;
            // 
            // btnObtenerDatos
            // 
            this.btnObtenerDatos.Location = new System.Drawing.Point(144, 101);
            this.btnObtenerDatos.Name = "btnObtenerDatos";
            this.btnObtenerDatos.Size = new System.Drawing.Size(162, 23);
            this.btnObtenerDatos.TabIndex = 18;
            this.btnObtenerDatos.Text = "Obtener datos";
            this.btnObtenerDatos.UseVisualStyleBackColor = true;
            this.btnObtenerDatos.Click += new System.EventHandler(this.btnObtenerDatos_Click);
            // 
            // ClientesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 336);
            this.Controls.Add(this.btnObtenerDatos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblContactos);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCliente);
            this.Name = "ClientesAdmin";
            this.Text = "ClientesAdmin";
            this.Load += new System.EventHandler(this.btnObtenerDatos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnObtenerDatos;
    }
}