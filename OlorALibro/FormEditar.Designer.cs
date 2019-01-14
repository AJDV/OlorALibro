namespace OlorALibro
{
    partial class FormEditar
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
            this.labelDireccio = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(8, 63);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelDireccio
            // 
            this.labelDireccio.AutoSize = true;
            this.labelDireccio.Location = new System.Drawing.Point(8, 114);
            this.labelDireccio.Name = "labelDireccio";
            this.labelDireccio.Size = new System.Drawing.Size(46, 13);
            this.labelDireccio.TabIndex = 1;
            this.labelDireccio.Text = "Direccio";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(8, 89);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(60, 60);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(276, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(174, 138);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(78, 32);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(258, 138);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(78, 32);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editar Libreria";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(60, 86);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(276, 20);
            this.textBoxTelefono.TabIndex = 9;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(60, 111);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(276, 20);
            this.textBoxDireccion.TabIndex = 10;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 182);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelDireccio);
            this.Controls.Add(this.labelNom);
            this.Name = "FormEditar";
            this.Text = "FormEditar";
            this.Load += new System.EventHandler(this.FormEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDireccio;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
    }
}