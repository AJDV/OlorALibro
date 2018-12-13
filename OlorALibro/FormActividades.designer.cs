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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActividades));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxActividad.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(22, 37);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(71, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(25, 90);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(59, 20);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(4, 195);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(103, 20);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(112, 34);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(326, 26);
            this.textBoxNombre.TabIndex = 3;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "";
            this.dateTimePickerFecha.Location = new System.Drawing.Point(112, 85);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(326, 26);
            this.dateTimePickerFecha.TabIndex = 4;
            this.dateTimePickerFecha.Value = new System.DateTime(2018, 11, 15, 0, 0, 0, 0);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(112, 195);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(325, 262);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderSize = 2;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(194, 477);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(113, 41);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAceptar.FlatAppearance.BorderSize = 2;
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(316, 477);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(113, 41);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // groupBoxActividad
            // 
            this.groupBoxActividad.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxActividad.Controls.Add(this.label2);
            this.groupBoxActividad.Controls.Add(this.label1);
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
            this.groupBoxActividad.Location = new System.Drawing.Point(25, 77);
            this.groupBoxActividad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxActividad.Name = "groupBoxActividad";
            this.groupBoxActividad.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxActividad.Size = new System.Drawing.Size(459, 532);
            this.groupBoxActividad.TabIndex = 6;
            this.groupBoxActividad.TabStop = false;
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.CustomFormat = "HH:mm";
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(112, 136);
            this.dateTimePickerHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(77, 26);
            this.dateTimePickerHora.TabIndex = 10;
            this.dateTimePickerHora.Value = new System.DateTime(2018, 11, 15, 22, 57, 0, 0);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.White;
            this.labelHora.Location = new System.Drawing.Point(25, 136);
            this.labelHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(48, 20);
            this.labelHora.TabIndex = 8;
            this.labelHora.Text = "Hora";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(60, 14);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(368, 58);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "ACTIVIDADES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "del";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "evento";
            // 
            // FormActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.rsz_back21;
            this.ClientSize = new System.Drawing.Size(509, 772);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.groupBoxActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.Actividades_Load);
            this.groupBoxActividad.ResumeLayout(false);
            this.groupBoxActividad.PerformLayout();
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
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}