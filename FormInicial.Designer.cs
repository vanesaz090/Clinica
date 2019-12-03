namespace Clinica
{
    partial class FormInicial
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.habioconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habioconsToolStripMenuItem,
            this.formularioVisitasToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(965, 24);
            this.menuStripTop.TabIndex = 11;
            this.menuStripTop.Text = "menuStripTop";
            // 
            // habioconsToolStripMenuItem
            // 
            this.habioconsToolStripMenuItem.Name = "habioconsToolStripMenuItem";
            this.habioconsToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.habioconsToolStripMenuItem.Text = "Ingresar habitación o consultorio";
            this.habioconsToolStripMenuItem.Click += new System.EventHandler(this.habioconsToolStripMenuItem_Click);
            // 
            // formularioVisitasToolStripMenuItem
            // 
            this.formularioVisitasToolStripMenuItem.Name = "formularioVisitasToolStripMenuItem";
            this.formularioVisitasToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.formularioVisitasToolStripMenuItem.Text = "Visitas realizadas por médicos";
            this.formularioVisitasToolStripMenuItem.Click += new System.EventHandler(this.formularioVisitasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.inventarioToolStripMenuItem.Text = "Médicos con mas servicios";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 86);
            this.label1.TabIndex = 15;
            this.label1.Text = "Clínica Médica";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLoggedInUser.Location = new System.Drawing.Point(27, 42);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.lblLoggedInUser.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(384, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 187);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoggedInUser);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem habioconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}