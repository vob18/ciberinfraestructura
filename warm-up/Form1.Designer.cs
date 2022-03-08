
namespace HolaMundo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMayuscula = new System.Windows.Forms.Label();
            this.lblEspecial = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinuscula = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "La contraseña debe contener al menos:";
            // 
            // lblMayuscula
            // 
            this.lblMayuscula.AutoSize = true;
            this.lblMayuscula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMayuscula.Location = new System.Drawing.Point(28, 73);
            this.lblMayuscula.Name = "lblMayuscula";
            this.lblMayuscula.Size = new System.Drawing.Size(109, 13);
            this.lblMayuscula.TabIndex = 1;
            this.lblMayuscula.Text = "- Una letra mayúscula";
            // 
            // lblEspecial
            // 
            this.lblEspecial.AutoSize = true;
            this.lblEspecial.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEspecial.Location = new System.Drawing.Point(28, 118);
            this.lblEspecial.Name = "lblEspecial";
            this.lblEspecial.Size = new System.Drawing.Size(147, 13);
            this.lblEspecial.TabIndex = 3;
            this.lblEspecial.Text = "- Un carácter especial (!#$%&.)";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNumero.Location = new System.Drawing.Point(28, 95);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "- Un número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contraeña";
            // 
            // lblMinuscula
            // 
            this.lblMinuscula.AutoSize = true;
            this.lblMinuscula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMinuscula.Location = new System.Drawing.Point(28, 51);
            this.lblMinuscula.Name = "lblMinuscula";
            this.lblMinuscula.Size = new System.Drawing.Size(103, 13);
            this.lblMinuscula.TabIndex = 4;
            this.lblMinuscula.Text = "-Una letra minúscula";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(31, 180);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(144, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(31, 229);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '*';
            this.txtPassConfirm.Size = new System.Drawing.Size(144, 20);
            this.txtPassConfirm.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Confirmar contraeña";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(31, 270);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 315);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMinuscula);
            this.Controls.Add(this.lblEspecial);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblMayuscula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validación de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMayuscula;
        private System.Windows.Forms.Label lblEspecial;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinuscula;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVerificar;
    }
}

