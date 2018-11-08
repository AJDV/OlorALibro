namespace OlorALibro
{
    partial class FormLogin
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLoginUserLabel = new System.Windows.Forms.Label();
            this.labelLoginPasswordLabel = new System.Windows.Forms.Label();
            this.textBoxLoginUserText = new System.Windows.Forms.TextBox();
            this.textBoxLoginPasswordText = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelIncorrecta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelLogin.Location = new System.Drawing.Point(91, 25);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(194, 39);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Olor a Libro";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLoginUserLabel
            // 
            this.labelLoginUserLabel.AutoSize = true;
            this.labelLoginUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginUserLabel.Location = new System.Drawing.Point(26, 85);
            this.labelLoginUserLabel.Name = "labelLoginUserLabel";
            this.labelLoginUserLabel.Size = new System.Drawing.Size(29, 13);
            this.labelLoginUserLabel.TabIndex = 1;
            this.labelLoginUserLabel.Text = "User";
            // 
            // labelLoginPasswordLabel
            // 
            this.labelLoginPasswordLabel.AutoSize = true;
            this.labelLoginPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPasswordLabel.Location = new System.Drawing.Point(26, 111);
            this.labelLoginPasswordLabel.Name = "labelLoginPasswordLabel";
            this.labelLoginPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.labelLoginPasswordLabel.TabIndex = 2;
            this.labelLoginPasswordLabel.Text = "Password";
            // 
            // textBoxLoginUserText
            // 
            this.textBoxLoginUserText.Location = new System.Drawing.Point(88, 82);
            this.textBoxLoginUserText.Name = "textBoxLoginUserText";
            this.textBoxLoginUserText.Size = new System.Drawing.Size(254, 20);
            this.textBoxLoginUserText.TabIndex = 1;
            // 
            // textBoxLoginPasswordText
            // 
            this.textBoxLoginPasswordText.Location = new System.Drawing.Point(88, 108);
            this.textBoxLoginPasswordText.Name = "textBoxLoginPasswordText";
            this.textBoxLoginPasswordText.PasswordChar = '•';
            this.textBoxLoginPasswordText.Size = new System.Drawing.Size(254, 20);
            this.textBoxLoginPasswordText.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(267, 134);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelIncorrecta
            // 
            this.labelIncorrecta.AutoSize = true;
            this.labelIncorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrecta.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrecta.Location = new System.Drawing.Point(29, 143);
            this.labelIncorrecta.Name = "labelIncorrecta";
            this.labelIncorrecta.Size = new System.Drawing.Size(148, 15);
            this.labelIncorrecta.TabIndex = 4;
            this.labelIncorrecta.Text = "Contraseña Incorrecta";
            this.labelIncorrecta.Visible = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 174);
            this.Controls.Add(this.labelIncorrecta);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxLoginPasswordText);
            this.Controls.Add(this.textBoxLoginUserText);
            this.Controls.Add(this.labelLoginPasswordLabel);
            this.Controls.Add(this.labelLoginUserLabel);
            this.Controls.Add(this.labelLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.Text = "Olor A Libro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLoginUserLabel;
        private System.Windows.Forms.Label labelLoginPasswordLabel;
        private System.Windows.Forms.TextBox textBoxLoginUserText;
        private System.Windows.Forms.TextBox textBoxLoginPasswordText;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelIncorrecta;
    }
}

