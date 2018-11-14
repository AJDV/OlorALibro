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
            this.dataGridViewLibrerias = new System.Windows.Forms.DataGridView();
            this.labelLibrerias = new System.Windows.Forms.Label();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libreriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrerias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibrerias
            // 
            this.dataGridViewLibrerias.AllowUserToAddRows = false;
            this.dataGridViewLibrerias.AllowUserToDeleteRows = false;
            this.dataGridViewLibrerias.AutoGenerateColumns = false;
            this.dataGridViewLibrerias.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewLibrerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrerias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.direccioDataGridViewTextBoxColumn});
            this.dataGridViewLibrerias.DataSource = this.libreriaBindingSource;
            this.dataGridViewLibrerias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewLibrerias.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewLibrerias.Name = "dataGridViewLibrerias";
            this.dataGridViewLibrerias.ReadOnly = true;
            this.dataGridViewLibrerias.Size = new System.Drawing.Size(609, 268);
            this.dataGridViewLibrerias.TabIndex = 0;
            this.dataGridViewLibrerias.Click += new System.EventHandler(this.dataGridViewLibrerias_Click);
            // 
            // labelLibrerias
            // 
            this.labelLibrerias.AutoSize = true;
            this.labelLibrerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrerias.Location = new System.Drawing.Point(12, 22);
            this.labelLibrerias.Name = "labelLibrerias";
            this.labelLibrerias.Size = new System.Drawing.Size(208, 55);
            this.labelLibrerias.TabIndex = 1;
            this.labelLibrerias.Text = "Librerias";
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.BackgroundImage = global::OlorALibro.Properties.Resources._001_plus;
            this.buttonAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAñadir.Location = new System.Drawing.Point(536, 27);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(61, 50);
            this.buttonAñadir.TabIndex = 2;
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccioDataGridViewTextBoxColumn
            // 
            this.direccioDataGridViewTextBoxColumn.DataPropertyName = "direccio";
            this.direccioDataGridViewTextBoxColumn.HeaderText = "Direccio";
            this.direccioDataGridViewTextBoxColumn.Name = "direccioDataGridViewTextBoxColumn";
            this.direccioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libreriaBindingSource
            // 
            this.libreriaBindingSource.DataSource = typeof(OlorALibro.Libreria);
            // 
            // FormLibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 359);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.labelLibrerias);
            this.Controls.Add(this.dataGridViewLibrerias);
            this.Name = "FormLibrerias";
            this.Text = "Librerias";
            this.Load += new System.EventHandler(this.FormLibrerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrerias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibrerias;
        private System.Windows.Forms.Label labelLibrerias;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource libreriaBindingSource;
    }
}