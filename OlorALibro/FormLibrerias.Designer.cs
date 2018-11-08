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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLibrerias = new System.Windows.Forms.Label();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Telefon,
            this.Direccio});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Direccio
            // 
            this.Direccio.DataPropertyName = "direccio";
            this.Direccio.HeaderText = "Direccio";
            this.Direccio.Name = "Direccio";
            this.Direccio.ReadOnly = true;
            // 
            // labelLibrerias
            // 
            this.labelLibrerias.AutoSize = true;
            this.labelLibrerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrerias.Location = new System.Drawing.Point(12, 9);
            this.labelLibrerias.Name = "labelLibrerias";
            this.labelLibrerias.Size = new System.Drawing.Size(208, 55);
            this.labelLibrerias.TabIndex = 1;
            this.labelLibrerias.Text = "Librerias";
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.BackgroundImage = global::OlorALibro.Properties.Resources._001_plus;
            this.buttonAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAñadir.Location = new System.Drawing.Point(226, 55);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(61, 50);
            this.buttonAñadir.TabIndex = 2;
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::OlorALibro.Properties.Resources._002_rubbish_bin;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Location = new System.Drawing.Point(300, 55);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(61, 50);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Librerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.labelLibrerias);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Librerias";
            this.Text = "Librerias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccio;
        private System.Windows.Forms.Label labelLibrerias;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonDelete;
    }
}