namespace OlorALibro
{
    partial class FormActividades
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBoxActividad = new System.Windows.Forms.GroupBox();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(70, 29);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(70, 65);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(69, 134);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(144, 26);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(226, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "";
            this.dateTimePickerFecha.Location = new System.Drawing.Point(144, 59);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickerFecha.TabIndex = 4;
            this.dateTimePickerFecha.Value = new System.DateTime(2018, 11, 15, 0, 0, 0, 0);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(143, 131);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(225, 88);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(212, 225);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(293, 225);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // groupBoxActividad
            // 
            this.groupBoxActividad.Controls.Add(this.dateTimePickerHora);
            this.groupBoxActividad.Controls.Add(this.labelHora);
            this.groupBoxActividad.Controls.Add(this.buttonCancelar);
            this.groupBoxActividad.Controls.Add(this.buttonAceptar);
            this.groupBoxActividad.Controls.Add(this.labelNombre);
            this.groupBoxActividad.Controls.Add(this.textBoxDescripcion);
            this.groupBoxActividad.Controls.Add(this.labelFecha);
            this.groupBoxActividad.Controls.Add(this.dateTimePickerFecha);
            this.groupBoxActividad.Controls.Add(this.labelDescripcion);
            this.groupBoxActividad.Controls.Add(this.textBoxNombre);
            this.groupBoxActividad.Location = new System.Drawing.Point(15, 230);
            this.groupBoxActividad.Name = "groupBoxActividad";
            this.groupBoxActividad.Size = new System.Drawing.Size(508, 258);
            this.groupBoxActividad.TabIndex = 6;
            this.groupBoxActividad.TabStop = false;
            this.groupBoxActividad.Text = "Actividad";
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.CustomFormat = "HH:mm";
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(309, 93);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(59, 20);
            this.dateTimePickerHora.TabIndex = 10;
            this.dateTimePickerHora.Value = new System.DateTime(2018, 11, 15, 22, 57, 0, 0);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(273, 99);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(30, 13);
            this.labelHora.TabIndex = 8;
            this.labelHora.Text = "Hora";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(23, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(481, 76);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "ACTIVIDADES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OlorALibro.Properties.Resources.calendario_actividades;
            this.pictureBox1.Location = new System.Drawing.Point(194, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.groupBoxActividad);
            this.Name = "FormActividades";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.Actividades_Load);
            this.groupBoxActividad.ResumeLayout(false);
            this.groupBoxActividad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.GroupBox groupBoxActividad;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
    }
}