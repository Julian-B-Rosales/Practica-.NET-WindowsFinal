namespace JulianRosales_WindowsFinal
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnValidaciones = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnHoras = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(192, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(192, 156);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(74, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(192, 221);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(65, 16);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "SUELDO:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(192, 277);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(66, 16);
            this.lblPuesto.TabIndex = 3;
            this.lblPuesto.Text = "PUESTO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(369, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(369, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(178, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(369, 218);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 22);
            this.txtSueldo.TabIndex = 6;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(369, 274);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(178, 22);
            this.txtPuesto.TabIndex = 7;
            // 
            // btnValidaciones
            // 
            this.btnValidaciones.Location = new System.Drawing.Point(623, 62);
            this.btnValidaciones.Name = "btnValidaciones";
            this.btnValidaciones.Size = new System.Drawing.Size(108, 47);
            this.btnValidaciones.TabIndex = 8;
            this.btnValidaciones.Text = "Validaciones";
            this.btnValidaciones.UseVisualStyleBackColor = true;
            this.btnValidaciones.Click += new System.EventHandler(this.btnValidaciones_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(623, 129);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(108, 43);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnHoras
            // 
            this.btnHoras.Location = new System.Drawing.Point(623, 195);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(108, 42);
            this.btnHoras.TabIndex = 10;
            this.btnHoras.Text = "Ingresar Horas";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(623, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnHoras);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnValidaciones);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button btnValidaciones;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

