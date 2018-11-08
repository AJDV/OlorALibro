namespace OlorALibro
{
    partial class FormAñadirLibreria
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
            this.labelNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelDireccio = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelNuevaLibreria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 80);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(12, 105);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 2;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelDireccio
            // 
            this.labelDireccio.AutoSize = true;
            this.labelDireccio.Location = new System.Drawing.Point(12, 131);
            this.labelDireccio.Name = "labelDireccio";
            this.labelDireccio.Size = new System.Drawing.Size(46, 13);
            this.labelDireccio.TabIndex = 3;
            this.labelDireccio.Text = "Direccio";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(61, 77);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);
            this.textBoxNom.TabIndex = 4;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(61, 102);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefon.TabIndex = 5;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(61, 128);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(200, 20);
            this.textBoxDir.TabIndex = 6;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(105, 167);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(197, 167);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelNuevaLibreria
            // 
            this.labelNuevaLibreria.AutoSize = true;
            this.labelNuevaLibreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaLibreria.Location = new System.Drawing.Point(19, 23);
            this.labelNuevaLibreria.Name = "labelNuevaLibreria";
            this.labelNuevaLibreria.Size = new System.Drawing.Size(242, 39);
            this.labelNuevaLibreria.TabIndex = 9;
            this.labelNuevaLibreria.Text = "Nueva Libreria";
            // 
            // FormAñadirLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.labelNuevaLibreria);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelDireccio);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNom);
            this.Name = "FormAñadirLibreria";
            this.Text = "FormAñadirLibreria";
            this.Load += new System.EventHandler(this.FormAñadirLibreria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelDireccio;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelNuevaLibreria;
    }
}