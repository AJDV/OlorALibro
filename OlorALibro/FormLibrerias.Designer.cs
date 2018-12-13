namespace OlorALibro
{
    partial class FormLibrerias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrerias));
            this.dataGridViewLibrerias = new System.Windows.Forms.DataGridView();
            this.linqWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxDireccio = new System.Windows.Forms.TextBox();
            this.labelLibrerias = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBoxActividades = new System.Windows.Forms.GroupBox();
            this.buttonEditarActividad = new System.Windows.Forms.Button();
            this.buttonEliminarActividad = new System.Windows.Forms.Button();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAltitud = new System.Windows.Forms.TextBox();
            this.textBoxLatitud = new System.Windows.Forms.TextBox();
            this.labelCoord = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.toolTipadd = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLink = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipAddLink = new System.Windows.Forms.ToolTip(this.components);
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libreriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrerias)).BeginInit();
            this.groupBoxActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibrerias
            // 
            this.dataGridViewLibrerias.AllowUserToAddRows = false;
            this.dataGridViewLibrerias.AllowUserToDeleteRows = false;
            this.dataGridViewLibrerias.AutoGenerateColumns = false;
            this.dataGridViewLibrerias.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLibrerias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewLibrerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrerias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.linqWeb});
            this.dataGridViewLibrerias.DataSource = this.libreriaBindingSource;
            this.dataGridViewLibrerias.Location = new System.Drawing.Point(28, 276);
            this.dataGridViewLibrerias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewLibrerias.Name = "dataGridViewLibrerias";
            this.dataGridViewLibrerias.ReadOnly = true;
            this.dataGridViewLibrerias.RowHeadersVisible = false;
            this.dataGridViewLibrerias.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewLibrerias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLibrerias.Size = new System.Drawing.Size(555, 181);
            this.dataGridViewLibrerias.TabIndex = 0;
            this.dataGridViewLibrerias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibrerias_CellClick);
            this.dataGridViewLibrerias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibrerias_CellContentClick);
            // 
            // linqWeb
            // 
            this.linqWeb.DataPropertyName = "linkWeb";
            this.linqWeb.HeaderText = "linqWeb";
            this.linqWeb.Name = "linqWeb";
            this.linqWeb.ReadOnly = true;
            this.linqWeb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(106, 58);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(264, 26);
            this.textBoxNom.TabIndex = 4;
            this.textBoxNom.Click += new System.EventHandler(this.textBoxNom_Click);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(106, 103);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(264, 26);
            this.textBoxTelefon.TabIndex = 5;
            // 
            // textBoxDireccio
            // 
            this.textBoxDireccio.Location = new System.Drawing.Point(106, 194);
            this.textBoxDireccio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDireccio.Name = "textBoxDireccio";
            this.textBoxDireccio.Size = new System.Drawing.Size(264, 26);
            this.textBoxDireccio.TabIndex = 6;
            // 
            // labelLibrerias
            // 
            this.labelLibrerias.AutoSize = true;
            this.labelLibrerias.BackColor = System.Drawing.Color.Transparent;
            this.labelLibrerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrerias.ForeColor = System.Drawing.Color.White;
            this.labelLibrerias.Location = new System.Drawing.Point(34, 0);
            this.labelLibrerias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLibrerias.Name = "labelLibrerias";
            this.labelLibrerias.Size = new System.Drawing.Size(200, 53);
            this.labelLibrerias.TabIndex = 7;
            this.labelLibrerias.Text = "Librerias";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(157, 234);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(146, 32);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(437, 476);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(146, 48);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar Libreria";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(248, 476);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(146, 48);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // groupBoxActividades
            // 
            this.groupBoxActividades.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxActividades.Controls.Add(this.buttonEditarActividad);
            this.groupBoxActividades.Controls.Add(this.buttonEliminarActividad);
            this.groupBoxActividades.Controls.Add(this.buttonAnadir);
            this.groupBoxActividades.Controls.Add(this.dataGridViewActividades);
            this.groupBoxActividades.ForeColor = System.Drawing.Color.White;
            this.groupBoxActividades.Location = new System.Drawing.Point(591, 108);
            this.groupBoxActividades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxActividades.Name = "groupBoxActividades";
            this.groupBoxActividades.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxActividades.Size = new System.Drawing.Size(431, 416);
            this.groupBoxActividades.TabIndex = 12;
            this.groupBoxActividades.TabStop = false;
            // 
            // buttonEditarActividad
            // 
            this.buttonEditarActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEditarActividad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditarActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEditarActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEditarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarActividad.ForeColor = System.Drawing.Color.White;
            this.buttonEditarActividad.Location = new System.Drawing.Point(265, 325);
            this.buttonEditarActividad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditarActividad.Name = "buttonEditarActividad";
            this.buttonEditarActividad.Size = new System.Drawing.Size(152, 35);
            this.buttonEditarActividad.TabIndex = 16;
            this.buttonEditarActividad.Text = "Editar Actividad";
            this.buttonEditarActividad.UseVisualStyleBackColor = true;
            this.buttonEditarActividad.Click += new System.EventHandler(this.buttonEditarActividad_Click);
            this.buttonEditarActividad.MouseLeave += new System.EventHandler(this.buttonEditarActividad_MouseLeave);
            this.buttonEditarActividad.MouseHover += new System.EventHandler(this.buttonEditarActividad_MouseHover);
            // 
            // buttonEliminarActividad
            // 
            this.buttonEliminarActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEliminarActividad.FlatAppearance.BorderSize = 3;
            this.buttonEliminarActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEliminarActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEliminarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarActividad.ForeColor = System.Drawing.Color.White;
            this.buttonEliminarActividad.Location = new System.Drawing.Point(172, 374);
            this.buttonEliminarActividad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEliminarActividad.Name = "buttonEliminarActividad";
            this.buttonEliminarActividad.Size = new System.Drawing.Size(96, 36);
            this.buttonEliminarActividad.TabIndex = 15;
            this.buttonEliminarActividad.Text = "Eliminar Actividad";
            this.buttonEliminarActividad.UseVisualStyleBackColor = true;
            this.buttonEliminarActividad.Click += new System.EventHandler(this.buttonEliminarActividad_Click);
            this.buttonEliminarActividad.MouseLeave += new System.EventHandler(this.buttonEliminarActividad_MouseLeave);
            this.buttonEliminarActividad.MouseHover += new System.EventHandler(this.buttonEliminarActividad_MouseHover);
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAnadir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAnadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAnadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnadir.ForeColor = System.Drawing.Color.White;
            this.buttonAnadir.Location = new System.Drawing.Point(22, 325);
            this.buttonAnadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(148, 35);
            this.buttonAnadir.TabIndex = 14;
            this.buttonAnadir.Text = "Añadir Actividad";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            this.buttonAnadir.MouseLeave += new System.EventHandler(this.buttonAnadir_MouseLeave);
            this.buttonAnadir.MouseHover += new System.EventHandler(this.buttonAnadir_MouseHover);
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.AllowUserToAddRows = false;
            this.dataGridViewActividades.AllowUserToDeleteRows = false;
            this.dataGridViewActividades.AutoGenerateColumns = false;
            this.dataGridViewActividades.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.fechaDataGridViewTextBoxColumn,
            this.hora,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridViewActividades.DataSource = this.actividadBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActividades.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewActividades.Location = new System.Drawing.Point(9, 20);
            this.dataGridViewActividades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.ReadOnly = true;
            this.dataGridViewActividades.RowHeadersVisible = false;
            this.dataGridViewActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActividades.Size = new System.Drawing.Size(404, 287);
            this.dataGridViewActividades.TabIndex = 13;
            this.dataGridViewActividades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActividades_CellDoubleClick);
            // 
            // hora
            // 
            this.hora.DataPropertyName = "Hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // textBoxAltitud
            // 
            this.textBoxAltitud.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxAltitud.Location = new System.Drawing.Point(406, 102);
            this.textBoxAltitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAltitud.Name = "textBoxAltitud";
            this.textBoxAltitud.Size = new System.Drawing.Size(171, 26);
            this.textBoxAltitud.TabIndex = 13;
            this.textBoxAltitud.Text = "ALTITUD";
            this.textBoxAltitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAltitud.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBoxAltitud.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBoxLatitud
            // 
            this.textBoxLatitud.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxLatitud.Location = new System.Drawing.Point(406, 149);
            this.textBoxLatitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLatitud.Name = "textBoxLatitud";
            this.textBoxLatitud.Size = new System.Drawing.Size(171, 26);
            this.textBoxLatitud.TabIndex = 14;
            this.textBoxLatitud.Text = "LATITUD";
            this.textBoxLatitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLatitud.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBoxLatitud.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.BackColor = System.Drawing.Color.Transparent;
            this.labelCoord.ForeColor = System.Drawing.Color.White;
            this.labelCoord.Location = new System.Drawing.Point(443, 47);
            this.labelCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(109, 20);
            this.labelCoord.TabIndex = 15;
            this.labelCoord.Text = "Coordenadas ";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(106, 149);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(264, 26);
            this.textBoxCorreo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(403, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "(ubicación de la Librería)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(696, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 52);
            this.label6.TabIndex = 19;
            this.label6.Text = "Actividades";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(54, 476);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 48);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseHover += new System.EventHandler(this.buttonAdd_MouseHover);
            // 
            // buttonLink
            // 
            this.buttonLink.BackColor = System.Drawing.Color.Transparent;
            this.buttonLink.BackgroundImage = global::OlorALibro.Properties.Resources.link1;
            this.buttonLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLink.FlatAppearance.BorderSize = 0;
            this.buttonLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLink.Location = new System.Drawing.Point(471, 217);
            this.buttonLink.Name = "buttonLink";
            this.buttonLink.Size = new System.Drawing.Size(35, 36);
            this.buttonLink.TabIndex = 21;
            this.buttonLink.UseVisualStyleBackColor = false;
            this.buttonLink.Click += new System.EventHandler(this.buttonLink_Click);
            this.buttonLink.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(448, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Link";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(483, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Web";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataSource = typeof(OlorALibro.Actividad);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libreriaBindingSource
            // 
            this.libreriaBindingSource.DataSource = typeof(OlorALibro.Libreria);
            // 
            // FormLibrerias
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 529);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonLink);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelCoord);
            this.Controls.Add(this.textBoxLatitud);
            this.Controls.Add(this.textBoxAltitud);
            this.Controls.Add(this.groupBoxActividades);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelLibrerias);
            this.Controls.Add(this.textBoxDireccio);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLibrerias);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLibrerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librerias";
            this.Activated += new System.EventHandler(this.FormLibrerias_Activated);
            this.Load += new System.EventHandler(this.Librerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrerias)).EndInit();
            this.groupBoxActividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibrerias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxDireccio;
        private System.Windows.Forms.Label labelLibrerias;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.BindingSource libreriaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxActividades;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private System.Windows.Forms.Button buttonEditarActividad;
        private System.Windows.Forms.Button buttonEliminarActividad;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxAltitud;
        private System.Windows.Forms.TextBox textBoxLatitud;
        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ToolTip toolTipadd;
        private System.Windows.Forms.Button buttonLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipAddLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linqWeb;
    }
}