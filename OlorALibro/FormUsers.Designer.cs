namespace OlorALibro
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.labelTituloUsers = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonCorreo = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.labelUserP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPuntos = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMail = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.buttonNotif = new System.Windows.Forms.Button();
            this.labelNot = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloUsers
            // 
            this.labelTituloUsers.AutoSize = true;
            this.labelTituloUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloUsers.ForeColor = System.Drawing.Color.White;
            this.labelTituloUsers.Location = new System.Drawing.Point(13, 33);
            this.labelTituloUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloUsers.Name = "labelTituloUsers";
            this.labelTituloUsers.Size = new System.Drawing.Size(682, 61);
            this.labelTituloUsers.TabIndex = 7;
            this.labelTituloUsers.Text = "Administración de usuarios";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Location = new System.Drawing.Point(942, 33);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(82, 63);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            this.buttonEliminar.MouseHover += new System.EventHandler(this.buttonEliminar_MouseHover);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrar.BackgroundImage")));
            this.buttonMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Location = new System.Drawing.Point(755, 33);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(79, 63);
            this.buttonMostrar.TabIndex = 10;
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            this.buttonMostrar.MouseHover += new System.EventHandler(this.buttonMostrar_MouseHover);
            // 
            // buttonCorreo
            // 
            this.buttonCorreo.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCorreo.BackgroundImage")));
            this.buttonCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCorreo.FlatAppearance.BorderSize = 0;
            this.buttonCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorreo.Location = new System.Drawing.Point(840, 33);
            this.buttonCorreo.Name = "buttonCorreo";
            this.buttonCorreo.Size = new System.Drawing.Size(78, 63);
            this.buttonCorreo.TabIndex = 11;
            this.buttonCorreo.UseVisualStyleBackColor = false;
            this.buttonCorreo.Click += new System.EventHandler(this.buttonCorreo_Click);
            this.buttonCorreo.MouseHover += new System.EventHandler(this.buttonCorreo_MouseHover);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Puntos,
            this.Correo,
            this.Admin,
            this.Contrasenia,
            this.User});
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(35, 99);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersVisible = false;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(674, 286);
            this.dataGridViewUsuarios.TabIndex = 3;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Puntos
            // 
            this.Puntos.DataPropertyName = "Puntos";
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            this.Admin.Visible = false;
            // 
            // Contrasenia
            // 
            this.Contrasenia.DataPropertyName = "Contrasenia";
            this.Contrasenia.HeaderText = "Contrasenia";
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.ReadOnly = true;
            this.Contrasenia.Visible = false;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Visible = false;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUser.Controls.Add(this.labelUserP);
            this.groupBoxUser.Controls.Add(this.label5);
            this.groupBoxUser.Controls.Add(this.label4);
            this.groupBoxUser.Controls.Add(this.label3);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Controls.Add(this.textBoxPuntos);
            this.groupBoxUser.Controls.Add(this.textBoxCorreo);
            this.groupBoxUser.Controls.Add(this.textBoxNombre);
            this.groupBoxUser.Controls.Add(this.textBoxApellido);
            this.groupBoxUser.Controls.Add(this.textBoxUsuario);
            this.groupBoxUser.ForeColor = System.Drawing.Color.White;
            this.groupBoxUser.Location = new System.Drawing.Point(745, 102);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(367, 283);
            this.groupBoxUser.TabIndex = 12;
            this.groupBoxUser.TabStop = false;
            // 
            // labelUserP
            // 
            this.labelUserP.AutoSize = true;
            this.labelUserP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserP.ForeColor = System.Drawing.Color.White;
            this.labelUserP.Location = new System.Drawing.Point(109, 10);
            this.labelUserP.Name = "labelUserP";
            this.labelUserP.Size = new System.Drawing.Size(158, 46);
            this.labelUserP.TabIndex = 10;
            this.labelUserP.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "PUNTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // textBoxPuntos
            // 
            this.textBoxPuntos.Location = new System.Drawing.Point(154, 238);
            this.textBoxPuntos.Name = "textBoxPuntos";
            this.textBoxPuntos.ReadOnly = true;
            this.textBoxPuntos.Size = new System.Drawing.Size(185, 26);
            this.textBoxPuntos.TabIndex = 4;
            this.textBoxPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(154, 196);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.ReadOnly = true;
            this.textBoxCorreo.Size = new System.Drawing.Size(185, 26);
            this.textBoxCorreo.TabIndex = 3;
            this.textBoxCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(154, 112);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(185, 26);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(154, 154);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(185, 26);
            this.textBoxApellido.TabIndex = 1;
            this.textBoxApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(154, 71);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(185, 26);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonNotif
            // 
            this.buttonNotif.BackColor = System.Drawing.Color.Transparent;
            this.buttonNotif.BackgroundImage = global::OlorALibro.Properties.Resources.notificationsbutton;
            this.buttonNotif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNotif.FlatAppearance.BorderSize = 0;
            this.buttonNotif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonNotif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotif.Location = new System.Drawing.Point(1043, 31);
            this.buttonNotif.Name = "buttonNotif";
            this.buttonNotif.Size = new System.Drawing.Size(82, 63);
            this.buttonNotif.TabIndex = 13;
            this.buttonNotif.UseVisualStyleBackColor = false;
            this.buttonNotif.Click += new System.EventHandler(this.buttonNotif_Click);
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.BackColor = System.Drawing.Color.Transparent;
            this.labelNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNot.ForeColor = System.Drawing.Color.Red;
            this.labelNot.Location = new System.Drawing.Point(1099, 31);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(0, 36);
            this.labelNot.TabIndex = 14;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(OlorALibro.Usuario);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.backgroundDesktopAp;
            this.ClientSize = new System.Drawing.Size(1180, 408);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.buttonNotif);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.buttonCorreo);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelTituloUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTituloUsers;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonCorreo;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label labelUserP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPuntos;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.ToolTip toolTipMail;
        private System.Windows.Forms.ToolTip toolTipAdd;
        private System.Windows.Forms.Button buttonNotif;
        private System.Windows.Forms.Label labelNot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}