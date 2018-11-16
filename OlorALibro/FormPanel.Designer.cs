namespace OlorALibro.CRUD_users
{
    partial class formPanel
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonLibreria = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(12, 29);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUsers.Size = new System.Drawing.Size(262, 99);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "USUARIOS";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonLibreria
            // 
            this.buttonLibreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.buttonLibreria.Location = new System.Drawing.Point(280, 29);
            this.buttonLibreria.Name = "buttonLibreria";
            this.buttonLibreria.Size = new System.Drawing.Size(262, 99);
            this.buttonLibreria.TabIndex = 0;
            this.buttonLibreria.Text = "LIBRERIAS";
            this.buttonLibreria.UseVisualStyleBackColor = true;
            this.buttonLibreria.Click += new System.EventHandler(this.buttonLibreria_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 29);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 13);
            this.labelUser.TabIndex = 2;
            // 
            // formPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 137);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonLibreria);
            this.Controls.Add(this.buttonUsers);
            this.Name = "formPanel";
            this.Text = "Panel de administrador";
            this.Load += new System.EventHandler(this.formPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonLibreria;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label labelUser;
    }
}