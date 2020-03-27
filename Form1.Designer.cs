namespace WindowsEventos
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
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(138, 65);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(269, 26);
            this.txtbNombre.TabIndex = 0;
            this.txtbNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbCorreo_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtbCorreo
            // 
            this.txtbCorreo.Location = new System.Drawing.Point(138, 128);
            this.txtbCorreo.Name = "txtbCorreo";
            this.txtbCorreo.Size = new System.Drawing.Size(269, 26);
            this.txtbCorreo.TabIndex = 1;
            this.txtbCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbCorreo_KeyPress);
            this.txtbCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbCorreo_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(175, 375);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(164, 66);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(138, 188);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(269, 26);
            this.txtbTelefono.TabIndex = 2;
            this.txtbTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbCorreo_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(138, 255);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(269, 26);
            this.txtbDireccion.TabIndex = 3;
            this.txtbDireccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbCorreo_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dirección";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 499);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.txtbCorreo);
            this.Controls.Add(this.txtbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.Label label4;
    }
}

