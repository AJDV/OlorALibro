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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxLoginUserText = new System.Windows.Forms.TextBox();
            this.textBoxLoginPasswordText = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelIncorrecta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLoginUserText
            // 
            this.textBoxLoginUserText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLoginUserText.Location = new System.Drawing.Point(297, 67);
            this.textBoxLoginUserText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginUserText.Name = "textBoxLoginUserText";
            this.textBoxLoginUserText.Size = new System.Drawing.Size(192, 26);
            this.textBoxLoginUserText.TabIndex = 2;
            this.textBoxLoginUserText.Text = "User";
            this.textBoxLoginUserText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginUserText.TextChanged += new System.EventHandler(this.textBoxLoginUserText_TextChanged);
            this.textBoxLoginUserText.Enter += new System.EventHandler(this.textBoxLoginUserText_Enter);
            this.textBoxLoginUserText.Leave += new System.EventHandler(this.textBoxLoginUserText_Leave);
            // 
            // textBoxLoginPasswordText
            // 
            this.textBoxLoginPasswordText.AcceptsTab = true;
            this.textBoxLoginPasswordText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLoginPasswordText.Location = new System.Drawing.Point(297, 124);
            this.textBoxLoginPasswordText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginPasswordText.Name = "textBoxLoginPasswordText";
            this.textBoxLoginPasswordText.Size = new System.Drawing.Size(192, 26);
            this.textBoxLoginPasswordText.TabIndex = 3;
            this.textBoxLoginPasswordText.Text = "Password";
            this.textBoxLoginPasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginPasswordText.TextChanged += new System.EventHandler(this.textBoxLoginPasswordText_TextChanged);
            this.textBoxLoginPasswordText.Enter += new System.EventHandler(this.textBoxLoginPasswordText_Enter);
            this.textBoxLoginPasswordText.Leave += new System.EventHandler(this.textBoxLoginPasswordText_Leave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(338, 207);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(101, 35);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelIncorrecta
            // 
            this.labelIncorrecta.AutoSize = true;
            this.labelIncorrecta.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrecta.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrecta.Location = new System.Drawing.Point(282, 273);
            this.labelIncorrecta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIncorrecta.Name = "labelIncorrecta";
            this.labelIncorrecta.Size = new System.Drawing.Size(208, 22);
            this.labelIncorrecta.TabIndex = 4;
            this.labelIncorrecta.Text = "Contraseña Incorrecta";
            this.labelIncorrecta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(-19, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 285);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 380);
            this.Controls.Add(this.labelIncorrecta);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxLoginPasswordText);
            this.Controls.Add(this.textBoxLoginUserText);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLoginUserText;
        private System.Windows.Forms.TextBox textBoxLoginPasswordText;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelIncorrecta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

