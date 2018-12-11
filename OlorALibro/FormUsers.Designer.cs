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
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBoxGridViewUsuarios = new System.Windows.Forms.GroupBox();
            this.labelTituloUsers = new System.Windows.Forms.Label();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonCorreo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBoxGridViewUsuarios.SuspendLayout();
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
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(4, 24);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(677, 328);
            this.dataGridViewUsuarios.TabIndex = 3;
            this.dataGridViewUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellDoubleClick);
            // 
            // groupBoxGridViewUsuarios
            // 
            this.groupBoxGridViewUsuarios.Controls.Add(this.dataGridViewUsuarios);
            this.groupBoxGridViewUsuarios.Location = new System.Drawing.Point(22, 111);
            this.groupBoxGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGridViewUsuarios.Name = "groupBoxGridViewUsuarios";
            this.groupBoxGridViewUsuarios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGridViewUsuarios.Size = new System.Drawing.Size(685, 357);
            this.groupBoxGridViewUsuarios.TabIndex = 3;
            this.groupBoxGridViewUsuarios.TabStop = false;
            this.groupBoxGridViewUsuarios.Text = "Usuarios";
            // 
            // labelTituloUsers
            // 
            this.labelTituloUsers.AutoSize = true;
            this.labelTituloUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloUsers.ForeColor = System.Drawing.Color.White;
            this.labelTituloUsers.Location = new System.Drawing.Point(25, 45);
            this.labelTituloUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloUsers.Name = "labelTituloUsers";
            this.labelTituloUsers.Size = new System.Drawing.Size(682, 61);
            this.labelTituloUsers.TabIndex = 7;
            this.labelTituloUsers.Text = "Administración de usuarios";
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
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Location = new System.Drawing.Point(811, 59);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(66, 59);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrar.BackgroundImage")));
            this.buttonMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Location = new System.Drawing.Point(1129, 59);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(69, 59);
            this.buttonMostrar.TabIndex = 10;
            this.buttonMostrar.UseVisualStyleBackColor = false;
            // 
            // buttonCorreo
            // 
            this.buttonCorreo.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCorreo.BackgroundImage")));
            this.buttonCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCorreo.FlatAppearance.BorderSize = 0;
            this.buttonCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorreo.Location = new System.Drawing.Point(969, 59);
            this.buttonCorreo.Name = "buttonCorreo";
            this.buttonCorreo.Size = new System.Drawing.Size(65, 59);
            this.buttonCorreo.TabIndex = 11;
            this.buttonCorreo.UseVisualStyleBackColor = false;
            this.buttonCorreo.Click += new System.EventHandler(this.buttonCorreo_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1230, 486);
            this.Controls.Add(this.buttonCorreo);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelTituloUsers);
            this.Controls.Add(this.groupBoxGridViewUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBoxGridViewUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.GroupBox groupBoxGridViewUsuarios;
        private System.Windows.Forms.Label labelTituloUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonCorreo;
    }
}