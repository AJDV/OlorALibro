namespace OlorALibro
{
    partial class UsuariosAdmins
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adminitrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelUsuariosAdmin = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPassw2 = new System.Windows.Forms.Label();
            this.labelPassw = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adminitrador,
            this.User});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Adminitrador
            // 
            this.Adminitrador.DataPropertyName = "admin";
            this.Adminitrador.HeaderText = "admin";
            this.Adminitrador.Name = "Adminitrador";
            this.Adminitrador.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "user";
            this.User.HeaderText = "user";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // labelUsuariosAdmin
            // 
            this.labelUsuariosAdmin.AutoSize = true;
            this.labelUsuariosAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuariosAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuariosAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuariosAdmin.Location = new System.Drawing.Point(26, 25);
            this.labelUsuariosAdmin.Name = "labelUsuariosAdmin";
            this.labelUsuariosAdmin.Size = new System.Drawing.Size(189, 46);
            this.labelUsuariosAdmin.TabIndex = 1;
            this.labelUsuariosAdmin.Text = "Usuarios ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImage = global::OlorALibro.Properties.Resources.remove_user;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(312, 35);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(46, 45);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OlorALibro.Properties.Resources.new_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(398, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPassw2);
            this.groupBox1.Controls.Add(this.labelPassw);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.checkBoxAdmin);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(270, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // labelPassw2
            // 
            this.labelPassw2.AutoSize = true;
            this.labelPassw2.Location = new System.Drawing.Point(7, 92);
            this.labelPassw2.Name = "labelPassw2";
            this.labelPassw2.Size = new System.Drawing.Size(61, 13);
            this.labelPassw2.TabIndex = 11;
            this.labelPassw2.Text = "Contraseña";
            // 
            // labelPassw
            // 
            this.labelPassw.AutoSize = true;
            this.labelPassw.Location = new System.Drawing.Point(7, 57);
            this.labelPassw.Name = "labelPassw";
            this.labelPassw.Size = new System.Drawing.Size(61, 13);
            this.labelPassw.TabIndex = 10;
            this.labelPassw.Text = "Contraseña";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(7, 22);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 13);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "Usuario";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::OlorALibro.Properties.Resources.eye;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(192, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 45);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 3;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(47, 132);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAdmin.TabIndex = 2;
            this.checkBoxAdmin.Text = "Administrador";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::OlorALibro.Properties.Resources.eye;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(193, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 45);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // UsuariosAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.rsz_back2;
            this.ClientSize = new System.Drawing.Size(493, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelUsuariosAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsuariosAdmins";
            this.Text = "UsuariosAdmins";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adminitrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.Label labelUsuariosAdmin;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPassw2;
        private System.Windows.Forms.Label labelPassw;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button button2;
    }
}