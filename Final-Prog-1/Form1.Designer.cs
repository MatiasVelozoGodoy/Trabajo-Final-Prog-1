namespace Final_Prog_1
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
            this.btnVerDeuda = new System.Windows.Forms.Button();
            this.btnPagarDeuda = new System.Windows.Forms.Button();
            this.btnCargarDeuda = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCacelar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerDeuda
            // 
            this.btnVerDeuda.Location = new System.Drawing.Point(87, 280);
            this.btnVerDeuda.Name = "btnVerDeuda";
            this.btnVerDeuda.Size = new System.Drawing.Size(154, 23);
            this.btnVerDeuda.TabIndex = 5;
            this.btnVerDeuda.Text = "Ver Deuda";
            this.btnVerDeuda.UseVisualStyleBackColor = true;
            this.btnVerDeuda.Visible = false;
            this.btnVerDeuda.Click += new System.EventHandler(this.btnVerDeuda_Click);
            // 
            // btnPagarDeuda
            // 
            this.btnPagarDeuda.Location = new System.Drawing.Point(280, 280);
            this.btnPagarDeuda.Name = "btnPagarDeuda";
            this.btnPagarDeuda.Size = new System.Drawing.Size(154, 23);
            this.btnPagarDeuda.TabIndex = 6;
            this.btnPagarDeuda.Text = "Pagar Deuda";
            this.btnPagarDeuda.UseVisualStyleBackColor = true;
            this.btnPagarDeuda.Visible = false;
            this.btnPagarDeuda.Click += new System.EventHandler(this.btnPagarDeuda_Click);
            // 
            // btnCargarDeuda
            // 
            this.btnCargarDeuda.Location = new System.Drawing.Point(469, 280);
            this.btnCargarDeuda.Name = "btnCargarDeuda";
            this.btnCargarDeuda.Size = new System.Drawing.Size(154, 23);
            this.btnCargarDeuda.TabIndex = 7;
            this.btnCargarDeuda.Text = "Cargar Deuda";
            this.btnCargarDeuda.UseVisualStyleBackColor = true;
            this.btnCargarDeuda.Visible = false;
            this.btnCargarDeuda.Click += new System.EventHandler(this.brnCargarDeuda_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(280, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 63);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar nueva persona";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(280, 81);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(170, 63);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(266, 167);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(205, 20);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(280, 220);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCacelar
            // 
            this.btnCacelar.Location = new System.Drawing.Point(375, 220);
            this.btnCacelar.Name = "btnCacelar";
            this.btnCacelar.Size = new System.Drawing.Size(75, 23);
            this.btnCacelar.TabIndex = 4;
            this.btnCacelar.Text = "Cancelar";
            this.btnCacelar.UseVisualStyleBackColor = true;
            this.btnCacelar.Visible = false;
            this.btnCacelar.Click += new System.EventHandler(this.btnCacelar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(350, 151);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 479);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnCacelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCargarDeuda);
            this.Controls.Add(this.btnPagarDeuda);
            this.Controls.Add(this.btnVerDeuda);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerDeuda;
        private System.Windows.Forms.Button btnPagarDeuda;
        private System.Windows.Forms.Button btnCargarDeuda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCacelar;
        private System.Windows.Forms.Label lblDNI;
    }
}

