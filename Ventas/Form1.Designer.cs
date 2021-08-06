
namespace Ventas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelInstrucciones = new System.Windows.Forms.Label();
            this.pictureBoxCashier = new System.Windows.Forms.PictureBox();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Blue;
            this.labelLogin.Location = new System.Drawing.Point(35, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(415, 26);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Bienvenido al Sistema de Punto de Venta";
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.AutoSize = true;
            this.labelInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrucciones.Location = new System.Drawing.Point(97, 88);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(308, 20);
            this.labelInstrucciones.TabIndex = 2;
            this.labelInstrucciones.Text = "Teclee su Usuario y contraseña de acceso";
            // 
            // pictureBoxCashier
            // 
            this.pictureBoxCashier.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_24_Cash_Register_2924837;
            this.pictureBoxCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCashier.Location = new System.Drawing.Point(337, 169);
            this.pictureBoxCashier.Name = "pictureBoxCashier";
            this.pictureBoxCashier.Size = new System.Drawing.Size(133, 133);
            this.pictureBoxCashier.TabIndex = 5;
            this.pictureBoxCashier.TabStop = false;
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.BackgroundImage = global::Ventas.Properties.Resources.iconfinder_revisi_02_2191544;
            this.pictureBoxKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxKey.Location = new System.Drawing.Point(31, 169);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxKey.TabIndex = 4;
            this.pictureBoxKey.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(178, 221);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(178, 169);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 22);
            this.textBoxUser.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 331);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxCashier);
            this.Controls.Add(this.pictureBoxKey);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelInstrucciones;
        private System.Windows.Forms.PictureBox pictureBoxKey;
        private System.Windows.Forms.PictureBox pictureBoxCashier;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
    }
}

