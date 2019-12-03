namespace Clinica
{
    partial class FormHabCons
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvHabCon = new System.Windows.Forms.DataGridView();
            this.lblTusuario = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiempoOcupante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dateTimeRemodelacion = new System.Windows.Forms.DateTimePicker();
            this.cmbVivienda = new System.Windows.Forms.ComboBox();
            this.cmbVentanas = new System.Windows.Forms.ComboBox();
            this.txtOcupante = new System.Windows.Forms.TextBox();
            this.txtValAdministracion = new System.Windows.Forms.TextBox();
            this.comboBoxArrendatario = new System.Windows.Forms.ComboBox();
            this.comboBoxPropietario = new System.Windows.Forms.ComboBox();
            this.comboBoxHABoCON = new System.Windows.Forms.ComboBox();
            this.cmbDotacion = new System.Windows.Forms.ComboBox();
            this.txtValMetCua = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(243, 518);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(189, 45);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvHabCon
            // 
            this.dgvHabCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabCon.Location = new System.Drawing.Point(449, 46);
            this.dgvHabCon.Name = "dgvHabCon";
            this.dgvHabCon.Size = new System.Drawing.Size(818, 438);
            this.dgvHabCon.TabIndex = 48;
            // 
            // lblTusuario
            // 
            this.lblTusuario.AutoSize = true;
            this.lblTusuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTusuario.Location = new System.Drawing.Point(58, 386);
            this.lblTusuario.Name = "lblTusuario";
            this.lblTusuario.Size = new System.Drawing.Size(144, 17);
            this.lblTusuario.TabIndex = 44;
            this.lblTusuario.Text = "Fecha de remodelación";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(75, 358);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(127, 17);
            this.lblGenero.TabIndex = 42;
            this.lblGenero.Text = "Valor administración";
            this.lblGenero.Click += new System.EventHandler(this.lblGenero_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(67, 234);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(137, 17);
            this.lblDireccion.TabIndex = 40;
            this.lblDireccion.Text = "Valor metro cuadrado";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(142, 120);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 17);
            this.lblUsuario.TabIndex = 34;
            this.lblUsuario.Text = "Dotación";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(142, 89);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 17);
            this.lblCorreo.TabIndex = 32;
            this.lblCorreo.Text = "Longitud";
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(136, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 17);
            this.lblApellido.TabIndex = 30;
            this.lblApellido.Text = "Ubicación";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Location = new System.Drawing.Point(1207, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(34, 33);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(617, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(192, 21);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Consultorio o Habitación";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(141, 165);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(60, 17);
            this.lblPass.TabIndex = 36;
            this.lblPass.Text = "Ventanas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 36);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Propietario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Arrendatario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nombre Ocupante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tiempo de estadia";
            // 
            // txtTiempoOcupante
            // 
            this.txtTiempoOcupante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiempoOcupante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoOcupante.Location = new System.Drawing.Point(243, 455);
            this.txtTiempoOcupante.Multiline = true;
            this.txtTiempoOcupante.Name = "txtTiempoOcupante";
            this.txtTiempoOcupante.Size = new System.Drawing.Size(189, 29);
            this.txtTiempoOcupante.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Vivienda";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(48, 199);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(151, 17);
            this.lblTelefono.TabIndex = 38;
            this.lblTelefono.Text = "Consultorio o habitación";
            // 
            // dateTimeRemodelacion
            // 
            this.dateTimeRemodelacion.Location = new System.Drawing.Point(243, 386);
            this.dateTimeRemodelacion.Name = "dateTimeRemodelacion";
            this.dateTimeRemodelacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRemodelacion.TabIndex = 79;
            // 
            // cmbVivienda
            // 
            this.cmbVivienda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVivienda.FormattingEnabled = true;
            this.cmbVivienda.Location = new System.Drawing.Point(243, 260);
            this.cmbVivienda.Name = "cmbVivienda";
            this.cmbVivienda.Size = new System.Drawing.Size(189, 25);
            this.cmbVivienda.TabIndex = 78;
            // 
            // cmbVentanas
            // 
            this.cmbVentanas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVentanas.FormattingEnabled = true;
            this.cmbVentanas.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbVentanas.Location = new System.Drawing.Point(243, 157);
            this.cmbVentanas.Name = "cmbVentanas";
            this.cmbVentanas.Size = new System.Drawing.Size(189, 25);
            this.cmbVentanas.TabIndex = 77;
            // 
            // txtOcupante
            // 
            this.txtOcupante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOcupante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupante.Location = new System.Drawing.Point(243, 412);
            this.txtOcupante.Multiline = true;
            this.txtOcupante.Name = "txtOcupante";
            this.txtOcupante.Size = new System.Drawing.Size(189, 29);
            this.txtOcupante.TabIndex = 76;
            // 
            // txtValAdministracion
            // 
            this.txtValAdministracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValAdministracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValAdministracion.Location = new System.Drawing.Point(243, 346);
            this.txtValAdministracion.Multiline = true;
            this.txtValAdministracion.Name = "txtValAdministracion";
            this.txtValAdministracion.Size = new System.Drawing.Size(189, 29);
            this.txtValAdministracion.TabIndex = 75;
            // 
            // comboBoxArrendatario
            // 
            this.comboBoxArrendatario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArrendatario.FormattingEnabled = true;
            this.comboBoxArrendatario.Location = new System.Drawing.Point(243, 318);
            this.comboBoxArrendatario.Name = "comboBoxArrendatario";
            this.comboBoxArrendatario.Size = new System.Drawing.Size(189, 25);
            this.comboBoxArrendatario.TabIndex = 73;
            // 
            // comboBoxPropietario
            // 
            this.comboBoxPropietario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPropietario.FormattingEnabled = true;
            this.comboBoxPropietario.Location = new System.Drawing.Point(243, 287);
            this.comboBoxPropietario.Name = "comboBoxPropietario";
            this.comboBoxPropietario.Size = new System.Drawing.Size(189, 25);
            this.comboBoxPropietario.TabIndex = 74;
            // 
            // comboBoxHABoCON
            // 
            this.comboBoxHABoCON.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHABoCON.FormattingEnabled = true;
            this.comboBoxHABoCON.Location = new System.Drawing.Point(243, 191);
            this.comboBoxHABoCON.Name = "comboBoxHABoCON";
            this.comboBoxHABoCON.Size = new System.Drawing.Size(189, 25);
            this.comboBoxHABoCON.TabIndex = 72;
            // 
            // cmbDotacion
            // 
            this.cmbDotacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDotacion.FormattingEnabled = true;
            this.cmbDotacion.Items.AddRange(new object[] {
            "Baño, closets,Cama"});
            this.cmbDotacion.Location = new System.Drawing.Point(243, 112);
            this.cmbDotacion.Name = "cmbDotacion";
            this.cmbDotacion.Size = new System.Drawing.Size(189, 25);
            this.cmbDotacion.TabIndex = 71;
            // 
            // txtValMetCua
            // 
            this.txtValMetCua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValMetCua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValMetCua.Location = new System.Drawing.Point(243, 222);
            this.txtValMetCua.Multiline = true;
            this.txtValMetCua.Name = "txtValMetCua";
            this.txtValMetCua.Size = new System.Drawing.Size(189, 29);
            this.txtValMetCua.TabIndex = 70;
            // 
            // txtLongitud
            // 
            this.txtLongitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLongitud.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitud.Location = new System.Drawing.Point(243, 81);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(189, 25);
            this.txtLongitud.TabIndex = 69;
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Location = new System.Drawing.Point(243, 50);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(189, 25);
            this.cmbUbicacion.TabIndex = 80;
            // 
            // FormHabCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 749);
            this.Controls.Add(this.cmbUbicacion);
            this.Controls.Add(this.dateTimeRemodelacion);
            this.Controls.Add(this.cmbVivienda);
            this.Controls.Add(this.cmbVentanas);
            this.Controls.Add(this.txtOcupante);
            this.Controls.Add(this.txtValAdministracion);
            this.Controls.Add(this.comboBoxArrendatario);
            this.Controls.Add(this.comboBoxPropietario);
            this.Controls.Add(this.comboBoxHABoCON);
            this.Controls.Add(this.cmbDotacion);
            this.Controls.Add(this.txtValMetCua);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTiempoOcupante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvHabCon);
            this.Controls.Add(this.lblTusuario);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.panel1);
            this.Name = "FormHabCons";
            this.Text = "FormHabCons";
            this.Load += new System.EventHandler(this.FormHabCons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvHabCon;
        private System.Windows.Forms.Label lblTusuario;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiempoOcupante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DateTimePicker dateTimeRemodelacion;
        private System.Windows.Forms.ComboBox cmbVivienda;
        private System.Windows.Forms.ComboBox cmbVentanas;
        private System.Windows.Forms.TextBox txtOcupante;
        private System.Windows.Forms.TextBox txtValAdministracion;
        private System.Windows.Forms.ComboBox comboBoxArrendatario;
        private System.Windows.Forms.ComboBox comboBoxPropietario;
        private System.Windows.Forms.ComboBox comboBoxHABoCON;
        private System.Windows.Forms.ComboBox cmbDotacion;
        private System.Windows.Forms.TextBox txtValMetCua;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.ComboBox cmbUbicacion;
    }
}