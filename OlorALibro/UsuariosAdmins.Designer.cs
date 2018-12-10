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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adminitrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelUsuariosAdmin = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.labelPassw2 = new System.Windows.Forms.Label();
            this.labelPassw = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adminitrador,
            this.User});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(21, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(245, 170);
            this.dataGridView1.TabIndex = 0;
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
            this.labelUsuariosAdmin.Location = new System.Drawing.Point(53, 23);
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
            this.buttonDelete.Location = new System.Drawing.Point(293, 33);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(46, 45);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OlorALibro.Properties.Resources.new_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(399, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAdmin.Controls.Add(this.buttonAccept);
            this.groupBoxAdmin.Controls.Add(this.labelPassw2);
            this.groupBoxAdmin.Controls.Add(this.labelPassw);
            this.groupBoxAdmin.Controls.Add(this.labelUser);
            this.groupBoxAdmin.Controls.Add(this.textBox3);
            this.groupBoxAdmin.Controls.Add(this.checkBoxAdmin);
            this.groupBoxAdmin.Controls.Add(this.textBox2);
            this.groupBoxAdmin.Controls.Add(this.textBox1);
            this.groupBoxAdmin.Controls.Add(this.button3);
            this.groupBoxAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAdmin.Location = new System.Drawing.Point(265, 79);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(220, 170);
            this.groupBoxAdmin.TabIndex = 5;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Visible = false;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(60, 140);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(105, 25);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelPassw2
            // 
            this.labelPassw2.AutoSize = true;
            this.labelPassw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassw2.ForeColor = System.Drawing.Color.White;
            this.labelPassw2.Location = new System.Drawing.Point(0, 91);
            this.labelPassw2.Name = "labelPassw2";
            this.labelPassw2.Size = new System.Drawing.Size(71, 13);
            this.labelPassw2.TabIndex = 11;
            this.labelPassw2.Text = "Contraseña";
            // 
            // labelPassw
            // 
            this.labelPassw.AutoSize = true;
            this.labelPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassw.ForeColor = System.Drawing.Color.White;
            this.labelPassw.Location = new System.Drawing.Point(0, 56);
            this.labelPassw.Name = "labelPassw";
            this.labelPassw.Size = new System.Drawing.Size(71, 13);
            this.labelPassw.TabIndex = 10;
            this.labelPassw.Text = "Contraseña";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(0, 21);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(50, 13);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "Usuario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 2;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdmin.Location = new System.Drawing.Point(63, 111);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(102, 17);
            this.checkBoxAdmin.TabIndex = 4;
            this.checkBoxAdmin.Text = "Administrador";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::OlorALibro.Properties.Resources.eye;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(187, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 34);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // UsuariosAdmins
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.rsz_back2;
            this.ClientSize = new System.Drawing.Size(493, 258);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelUsuariosAdmin);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuariosAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosAdmins";
            this.Load += new System.EventHandler(this.UsuariosAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPassw2;
        private System.Windows.Forms.Label labelPassw;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}