namespace OlorALibro
{
    partial class ListaActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaActividades));
            this.dataGridViewListaActiv = new System.Windows.Forms.DataGridView();
            this.labelUsers = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaActiv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaActiv
            // 
            this.dataGridViewListaActiv.AllowUserToAddRows = false;
            this.dataGridViewListaActiv.AllowUserToDeleteRows = false;
            this.dataGridViewListaActiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaActiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.id_act,
            this.Hora,
            this.Fecha,
            this.Descripcion});
            this.dataGridViewListaActiv.Location = new System.Drawing.Point(28, 70);
            this.dataGridViewListaActiv.Name = "dataGridViewListaActiv";
            this.dataGridViewListaActiv.ReadOnly = true;
            this.dataGridViewListaActiv.RowHeadersVisible = false;
            this.dataGridViewListaActiv.RowTemplate.Height = 28;
            this.dataGridViewListaActiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaActiv.Size = new System.Drawing.Size(491, 368);
            this.dataGridViewListaActiv.TabIndex = 0;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.White;
            this.labelUsers.Location = new System.Drawing.Point(83, 25);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(371, 29);
            this.labelUsers.TabIndex = 3;
            this.labelUsers.Text = "ACCESO RAPIDO ACTIVIDADES";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Titulo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // id_act
            // 
            this.id_act.DataPropertyName = "id_act";
            this.id_act.HeaderText = "id_act";
            this.id_act.Name = "id_act";
            this.id_act.ReadOnly = true;
            this.id_act.Visible = false;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ListaActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.backgroundDesktopAp;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.dataGridViewListaActiv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaActividades";
            this.Load += new System.EventHandler(this.ListaActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaActiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaActiv;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_act;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}