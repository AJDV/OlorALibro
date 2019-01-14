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
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBoxGridViewUsuarios = new System.Windows.Forms.GroupBox();
            this.labelTituloUsers = new System.Windows.Forms.Label();
            this.groupBoxEdicion = new System.Windows.Forms.GroupBox();
            this.tabControlEdicion = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAddCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAddPuntos = new System.Windows.Forms.TextBox();
            this.textBoxAddApellido = new System.Windows.Forms.TextBox();
            this.textBoxAddNombre = new System.Windows.Forms.TextBox();
            this.textBoxAddContrasenia = new System.Windows.Forms.TextBox();
            this.textBoxAddUser = new System.Windows.Forms.TextBox();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.tabPageEditar = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEditCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxEditPuntos = new System.Windows.Forms.TextBox();
            this.textBoxEditApellido = new System.Windows.Forms.TextBox();
            this.textBoxEditNombre = new System.Windows.Forms.TextBox();
            this.textBoxEditContrasenia = new System.Windows.Forms.TextBox();
            this.textBoxEditUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAniadir = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBorrar = new System.Windows.Forms.ToolStripButton();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBoxGridViewUsuarios.SuspendLayout();
            this.groupBoxEdicion.SuspendLayout();
            this.tabControlEdicion.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEditar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AutoGenerateColumns = false;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn,
            this.contraseniaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.puntosDataGridViewTextBoxColumn});
            this.dataGridViewUsuarios.DataSource = this.usuarioBindingSource;
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(550, 213);
            this.dataGridViewUsuarios.TabIndex = 3;
            this.dataGridViewUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellDoubleClick);
            // 
            // groupBoxGridViewUsuarios
            // 
            this.groupBoxGridViewUsuarios.Controls.Add(this.dataGridViewUsuarios);
            this.groupBoxGridViewUsuarios.Location = new System.Drawing.Point(15, 72);
            this.groupBoxGridViewUsuarios.Name = "groupBoxGridViewUsuarios";
            this.groupBoxGridViewUsuarios.Size = new System.Drawing.Size(556, 232);
            this.groupBoxGridViewUsuarios.TabIndex = 3;
            this.groupBoxGridViewUsuarios.TabStop = false;
            this.groupBoxGridViewUsuarios.Text = "Usuarios";
            // 
            // labelTituloUsers
            // 
            this.labelTituloUsers.AutoSize = true;
            this.labelTituloUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloUsers.Location = new System.Drawing.Point(45, 30);
            this.labelTituloUsers.Name = "labelTituloUsers";
            this.labelTituloUsers.Size = new System.Drawing.Size(461, 39);
            this.labelTituloUsers.TabIndex = 7;
            this.labelTituloUsers.Text = "Administración de usuarios";
            // 
            // groupBoxEdicion
            // 
            this.groupBoxEdicion.Controls.Add(this.tabControlEdicion);
            this.groupBoxEdicion.Location = new System.Drawing.Point(577, 28);
            this.groupBoxEdicion.Name = "groupBoxEdicion";
            this.groupBoxEdicion.Size = new System.Drawing.Size(328, 276);
            this.groupBoxEdicion.TabIndex = 8;
            this.groupBoxEdicion.TabStop = false;
            this.groupBoxEdicion.Text = "Edicion";
            // 
            // tabControlEdicion
            // 
            this.tabControlEdicion.Controls.Add(this.tabPageAdd);
            this.tabControlEdicion.Controls.Add(this.tabPageEditar);
            this.tabControlEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEdicion.Location = new System.Drawing.Point(3, 16);
            this.tabControlEdicion.Name = "tabControlEdicion";
            this.tabControlEdicion.SelectedIndex = 0;
            this.tabControlEdicion.Size = new System.Drawing.Size(322, 257);
            this.tabControlEdicion.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.label7);
            this.tabPageAdd.Controls.Add(this.textBoxAddCorreo);
            this.tabPageAdd.Controls.Add(this.labelCorreo);
            this.tabPageAdd.Controls.Add(this.buttonAdd);
            this.tabPageAdd.Controls.Add(this.textBoxAddPuntos);
            this.tabPageAdd.Controls.Add(this.textBoxAddApellido);
            this.tabPageAdd.Controls.Add(this.textBoxAddNombre);
            this.tabPageAdd.Controls.Add(this.textBoxAddContrasenia);
            this.tabPageAdd.Controls.Add(this.textBoxAddUser);
            this.tabPageAdd.Controls.Add(this.labelPuntos);
            this.tabPageAdd.Controls.Add(this.labelApellido);
            this.tabPageAdd.Controls.Add(this.labelNombre);
            this.tabPageAdd.Controls.Add(this.labelContrasenia);
            this.tabPageAdd.Controls.Add(this.labelUser);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(314, 231);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Añadir Usuario";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Añadir usuario";
            // 
            // textBoxAddCorreo
            // 
            this.textBoxAddCorreo.Location = new System.Drawing.Point(118, 145);
            this.textBoxAddCorreo.Name = "textBoxAddCorreo";
            this.textBoxAddCorreo.Size = new System.Drawing.Size(178, 20);
            this.textBoxAddCorreo.TabIndex = 5;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(21, 148);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 7;
            this.labelCorreo.Text = "Correo:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(221, 197);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAddPuntos
            // 
            this.textBoxAddPuntos.Location = new System.Drawing.Point(118, 171);
            this.textBoxAddPuntos.Name = "textBoxAddPuntos";
            this.textBoxAddPuntos.Size = new System.Drawing.Size(178, 20);
            this.textBoxAddPuntos.TabIndex = 6;
            // 
            // textBoxAddApellido
            // 
            this.textBoxAddApellido.Location = new System.Drawing.Point(118, 119);
            this.textBoxAddApellido.Name = "textBoxAddApellido";
            this.textBoxAddApellido.Size = new System.Drawing.Size(178, 20);
            this.textBoxAddApellido.TabIndex = 4;
            // 
            // textBoxAddNombre
            // 
            this.textBoxAddNombre.Location = new System.Drawing.Point(118, 93);
            this.textBoxAddNombre.Name = "textBoxAddNombre";
            this.textBoxAddNombre.Size = new System.Drawing.Size(178, 20);
            this.textBoxAddNombre.TabIndex = 3;
            // 
            // textBoxAddContrasenia
            // 
            this.textBoxAddContrasenia.Location = new System.Drawing.Point(118, 67);
            this.textBoxAddContrasenia.Name = "textBoxAddContrasenia";
            this.textBoxAddContrasenia.Size = new System.Drawing.Size(178, 20);
            this.textBoxAddContrasenia.TabIndex = 2;
            // 
            // textBoxAddUser
            // 
            this.textBoxAddUser.Location = new System.Drawing.Point(118, 41);
            this.textBoxAddUser.Name = "textBoxAddUser";
            this.textBoxAddUser.Size = new System.Drawing.Size(178, 20);
            this.textBoxAddUser.TabIndex = 1;
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Location = new System.Drawing.Point(21, 174);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(43, 13);
            this.labelPuntos.TabIndex = 4;
            this.labelPuntos.Text = "Puntos:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(21, 122);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(21, 96);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Location = new System.Drawing.Point(21, 70);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(64, 13);
            this.labelContrasenia.TabIndex = 1;
            this.labelContrasenia.Text = "Contraseña:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(21, 44);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User:";
            // 
            // tabPageEditar
            // 
            this.tabPageEditar.Controls.Add(this.label8);
            this.tabPageEditar.Controls.Add(this.textBoxEditCorreo);
            this.tabPageEditar.Controls.Add(this.label1);
            this.tabPageEditar.Controls.Add(this.buttonEdit);
            this.tabPageEditar.Controls.Add(this.textBoxEditPuntos);
            this.tabPageEditar.Controls.Add(this.textBoxEditApellido);
            this.tabPageEditar.Controls.Add(this.textBoxEditNombre);
            this.tabPageEditar.Controls.Add(this.textBoxEditContrasenia);
            this.tabPageEditar.Controls.Add(this.textBoxEditUser);
            this.tabPageEditar.Controls.Add(this.label2);
            this.tabPageEditar.Controls.Add(this.label3);
            this.tabPageEditar.Controls.Add(this.label4);
            this.tabPageEditar.Controls.Add(this.label5);
            this.tabPageEditar.Controls.Add(this.label6);
            this.tabPageEditar.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditar.Name = "tabPageEditar";
            this.tabPageEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditar.Size = new System.Drawing.Size(314, 231);
            this.tabPageEditar.TabIndex = 1;
            this.tabPageEditar.Text = "Editar Usuario";
            this.tabPageEditar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Editar usuario";
            // 
            // textBoxEditCorreo
            // 
            this.textBoxEditCorreo.Location = new System.Drawing.Point(118, 145);
            this.textBoxEditCorreo.Name = "textBoxEditCorreo";
            this.textBoxEditCorreo.Size = new System.Drawing.Size(178, 20);
            this.textBoxEditCorreo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Correo:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(221, 197);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxEditPuntos
            // 
            this.textBoxEditPuntos.Location = new System.Drawing.Point(118, 171);
            this.textBoxEditPuntos.Name = "textBoxEditPuntos";
            this.textBoxEditPuntos.Size = new System.Drawing.Size(178, 20);
            this.textBoxEditPuntos.TabIndex = 6;
            // 
            // textBoxEditApellido
            // 
            this.textBoxEditApellido.Location = new System.Drawing.Point(118, 119);
            this.textBoxEditApellido.Name = "textBoxEditApellido";
            this.textBoxEditApellido.Size = new System.Drawing.Size(178, 20);
            this.textBoxEditApellido.TabIndex = 4;
            // 
            // textBoxEditNombre
            // 
            this.textBoxEditNombre.Location = new System.Drawing.Point(118, 93);
            this.textBoxEditNombre.Name = "textBoxEditNombre";
            this.textBoxEditNombre.Size = new System.Drawing.Size(178, 20);
            this.textBoxEditNombre.TabIndex = 3;
            // 
            // textBoxEditContrasenia
            // 
            this.textBoxEditContrasenia.Location = new System.Drawing.Point(118, 67);
            this.textBoxEditContrasenia.Name = "textBoxEditContrasenia";
            this.textBoxEditContrasenia.Size = new System.Drawing.Size(178, 20);
            this.textBoxEditContrasenia.TabIndex = 2;
            // 
            // textBoxEditUser
            // 
            this.textBoxEditUser.Location = new System.Drawing.Point(118, 41);
            this.textBoxEditUser.Name = "textBoxEditUser";
            this.textBoxEditUser.Size = new System.Drawing.Size(178, 20);
            this.textBoxEditUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Puntos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "User:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAniadir,
            this.toolStripEditar,
            this.toolStripSeparator1,
            this.toolStripBorrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(917, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAniadir
            // 
            this.toolStripAniadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAniadir.Image = global::OlorALibro.Properties.Resources.add;
            this.toolStripAniadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAniadir.Name = "toolStripAniadir";
            this.toolStripAniadir.Size = new System.Drawing.Size(23, 22);
            this.toolStripAniadir.Text = "Añadir usuario";
            this.toolStripAniadir.Click += new System.EventHandler(this.toolStripAniadir_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditar.Image = global::OlorALibro.Properties.Resources.edit;
            this.toolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(23, 22);
            this.toolStripEditar.Text = "Editar usuario";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBorrar
            // 
            this.toolStripBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBorrar.Image = global::OlorALibro.Properties.Resources.rubbish_bin;
            this.toolStripBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBorrar.Name = "toolStripBorrar";
            this.toolStripBorrar.Size = new System.Drawing.Size(23, 22);
            this.toolStripBorrar.Text = "Borrar usuario";
            this.toolStripBorrar.Click += new System.EventHandler(this.toolStripBorrar_Click);
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseniaDataGridViewTextBoxColumn
            // 
            this.contraseniaDataGridViewTextBoxColumn.DataPropertyName = "Contrasenia";
            this.contraseniaDataGridViewTextBoxColumn.HeaderText = "Contrasenia";
            this.contraseniaDataGridViewTextBoxColumn.Name = "contraseniaDataGridViewTextBoxColumn";
            this.contraseniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puntosDataGridViewTextBoxColumn
            // 
            this.puntosDataGridViewTextBoxColumn.DataPropertyName = "Puntos";
            this.puntosDataGridViewTextBoxColumn.HeaderText = "Puntos";
            this.puntosDataGridViewTextBoxColumn.Name = "puntosDataGridViewTextBoxColumn";
            this.puntosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(OlorALibro.Usuario);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 316);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxEdicion);
            this.Controls.Add(this.labelTituloUsers);
            this.Controls.Add(this.groupBoxGridViewUsuarios);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBoxGridViewUsuarios.ResumeLayout(false);
            this.groupBoxEdicion.ResumeLayout(false);
            this.tabControlEdicion.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEditar.ResumeLayout(false);
            this.tabPageEditar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.GroupBox groupBoxGridViewUsuarios;
        private System.Windows.Forms.Label labelTituloUsers;
        private System.Windows.Forms.GroupBox groupBoxEdicion;
        private System.Windows.Forms.TabControl tabControlEdicion;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageEditar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAniadir;
        private System.Windows.Forms.ToolStripButton toolStripBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAddPuntos;
        private System.Windows.Forms.TextBox textBoxAddApellido;
        private System.Windows.Forms.TextBox textBoxAddNombre;
        private System.Windows.Forms.TextBox textBoxAddContrasenia;
        private System.Windows.Forms.TextBox textBoxAddUser;
        private System.Windows.Forms.TextBox textBoxAddCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox textBoxEditCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxEditPuntos;
        private System.Windows.Forms.TextBox textBoxEditApellido;
        private System.Windows.Forms.TextBox textBoxEditNombre;
        private System.Windows.Forms.TextBox textBoxEditContrasenia;
        private System.Windows.Forms.TextBox textBoxEditUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}