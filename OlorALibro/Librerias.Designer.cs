namespace OlorALibro
{
    partial class Librerias
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
            this.labelLibreria = new System.Windows.Forms.Label();
            this.labelActividades = new System.Windows.Forms.Label();
            this.textBoxLibreria = new System.Windows.Forms.TextBox();
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLibreria = new System.Windows.Forms.GroupBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            this.groupBoxLibreria.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLibreria
            // 
            this.labelLibreria.AutoSize = true;
            this.labelLibreria.Location = new System.Drawing.Point(12, 24);
            this.labelLibreria.Name = "labelLibreria";
            this.labelLibreria.Size = new System.Drawing.Size(44, 13);
            this.labelLibreria.TabIndex = 0;
            this.labelLibreria.Text = "Nombre";
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.Location = new System.Drawing.Point(12, 59);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(62, 13);
            this.labelActividades.TabIndex = 1;
            this.labelActividades.Text = "Actividades";
            // 
            // textBoxLibreria
            // 
            this.textBoxLibreria.Location = new System.Drawing.Point(94, 21);
            this.textBoxLibreria.Name = "textBoxLibreria";
            this.textBoxLibreria.Size = new System.Drawing.Size(457, 20);
            this.textBoxLibreria.TabIndex = 2;
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.AllowUserToAddRows = false;
            this.dataGridViewActividades.AllowUserToDeleteRows = false;
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha,
            this.Descripción});
            this.dataGridViewActividades.Location = new System.Drawing.Point(94, 59);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.ReadOnly = true;
            this.dataGridViewActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActividades.Size = new System.Drawing.Size(457, 199);
            this.dataGridViewActividades.TabIndex = 3;
            this.dataGridViewActividades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActividades_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // groupBoxLibreria
            // 
            this.groupBoxLibreria.Controls.Add(this.buttonEditar);
            this.groupBoxLibreria.Controls.Add(this.buttonEliminar);
            this.groupBoxLibreria.Controls.Add(this.buttonAnadir);
            this.groupBoxLibreria.Controls.Add(this.buttonCancelar);
            this.groupBoxLibreria.Controls.Add(this.buttonAceptar);
            this.groupBoxLibreria.Controls.Add(this.dataGridViewActividades);
            this.groupBoxLibreria.Controls.Add(this.labelLibreria);
            this.groupBoxLibreria.Controls.Add(this.textBoxLibreria);
            this.groupBoxLibreria.Controls.Add(this.labelActividades);
            this.groupBoxLibreria.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLibreria.Name = "groupBoxLibreria";
            this.groupBoxLibreria.Size = new System.Drawing.Size(600, 298);
            this.groupBoxLibreria.TabIndex = 4;
            this.groupBoxLibreria.TabStop = false;
            this.groupBoxLibreria.Text = "Libreria";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(558, 118);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(36, 23);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Edit";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(558, 89);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(36, 23);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "-";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Location = new System.Drawing.Point(557, 59);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(37, 23);
            this.buttonAnadir.TabIndex = 6;
            this.buttonAnadir.Text = "+";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(395, 264);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(476, 264);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // Librerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 319);
            this.Controls.Add(this.groupBoxLibreria);
            this.Name = "Librerias";
            this.Text = "Libreria";
            this.Activated += new System.EventHandler(this.Librerias_Activated);
            this.Load += new System.EventHandler(this.Librerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            this.groupBoxLibreria.ResumeLayout(false);
            this.groupBoxLibreria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLibreria;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.TextBox textBoxLibreria;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.GroupBox groupBoxLibreria;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
    }
}