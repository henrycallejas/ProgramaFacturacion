namespace proyecto_dae.formularios
{
    partial class Frmproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmproductos));
            this.dataGridproducto = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnsalirr = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            this.btneli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescripcionproduc = new System.Windows.Forms.TextBox();
            this.txtnomproduc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnmiminizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproducto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmiminizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridproducto
            // 
            this.dataGridproducto.AllowUserToOrderColumns = true;
            this.dataGridproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridproducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridproducto.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridproducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridproducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridproducto.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridproducto.Location = new System.Drawing.Point(-1, 343);
            this.dataGridproducto.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridproducto.MultiSelect = false;
            this.dataGridproducto.Name = "dataGridproducto";
            this.dataGridproducto.RowHeadersWidth = 62;
            this.dataGridproducto.RowTemplate.Height = 28;
            this.dataGridproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridproducto.Size = new System.Drawing.Size(737, 83);
            this.dataGridproducto.TabIndex = 59;
            this.dataGridproducto.Click += new System.EventHandler(this.dataGridproducto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnRestablecer);
            this.groupBox3.Controls.Add(this.txtbuscar);
            this.groupBox3.Controls.Add(this.btnbuscar);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(202, 279);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(528, 59);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 11F);
            this.label6.Location = new System.Drawing.Point(220, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "POR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 11F);
            this.label5.Location = new System.Drawing.Point(24, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "BUSCAR";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.Teal;
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRestablecer.Location = new System.Drawing.Point(438, 21);
            this.btnRestablecer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(78, 21);
            this.btnRestablecer.TabIndex = 49;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.DarkGray;
            this.txtbuscar.Location = new System.Drawing.Point(103, 25);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(113, 19);
            this.txtbuscar.TabIndex = 46;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Teal;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnbuscar.Location = new System.Drawing.Point(376, 21);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(50, 21);
            this.btnbuscar.TabIndex = 48;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.btnreporte);
            this.groupBox2.Controls.Add(this.btnsalirr);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Controls.Add(this.btguardar);
            this.groupBox2.Controls.Add(this.btnmodi);
            this.groupBox2.Controls.Add(this.btneli);
            this.groupBox2.Location = new System.Drawing.Point(-1, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(731, 62);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCIONES";
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.Color.Teal;
            this.btnreporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnreporte.Image = global::proyecto_dae.Properties.Resources.printer;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreporte.Location = new System.Drawing.Point(487, 23);
            this.btnreporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(98, 29);
            this.btnreporte.TabIndex = 43;
            this.btnreporte.Text = "REPORTE";
            this.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // btnsalirr
            // 
            this.btnsalirr.BackColor = System.Drawing.Color.Teal;
            this.btnsalirr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnsalirr.Image = global::proyecto_dae.Properties.Resources.back_24x24_32;
            this.btnsalirr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirr.Location = new System.Drawing.Point(613, 23);
            this.btnsalirr.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalirr.Name = "btnsalirr";
            this.btnsalirr.Size = new System.Drawing.Size(100, 29);
            this.btnsalirr.TabIndex = 42;
            this.btnsalirr.Text = "SALIR";
            this.btnsalirr.UseVisualStyleBackColor = false;
            this.btnsalirr.Click += new System.EventHandler(this.btnsalirr_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Teal;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnnuevo.Image = global::proyecto_dae.Properties.Resources._new;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(244, 23);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 29);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btguardar
            // 
            this.btguardar.BackColor = System.Drawing.Color.Teal;
            this.btguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btguardar.Image = global::proyecto_dae.Properties.Resources.guardar;
            this.btguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btguardar.Location = new System.Drawing.Point(343, 23);
            this.btguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(98, 29);
            this.btguardar.TabIndex = 2;
            this.btguardar.Text = "GUARDAR";
            this.btguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btguardar.UseVisualStyleBackColor = false;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btnmodi
            // 
            this.btnmodi.BackColor = System.Drawing.Color.Teal;
            this.btnmodi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnmodi.Image = global::proyecto_dae.Properties.Resources.app_edit_32x32_32;
            this.btnmodi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodi.Location = new System.Drawing.Point(127, 23);
            this.btnmodi.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(97, 29);
            this.btnmodi.TabIndex = 1;
            this.btnmodi.Text = "MODIFICAR";
            this.btnmodi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodi.UseVisualStyleBackColor = false;
            this.btnmodi.Click += new System.EventHandler(this.btnmodi_Click);
            // 
            // btneli
            // 
            this.btneli.BackColor = System.Drawing.Color.Teal;
            this.btneli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btneli.Image = global::proyecto_dae.Properties.Resources.remove_24x24_32;
            this.btneli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneli.Location = new System.Drawing.Point(16, 23);
            this.btneli.Margin = new System.Windows.Forms.Padding(2);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(84, 29);
            this.btneli.TabIndex = 0;
            this.btneli.Text = "ELIMINAR";
            this.btneli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneli.UseVisualStyleBackColor = false;
            this.btneli.Click += new System.EventHandler(this.btneli_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtdescripcionproduc);
            this.groupBox1.Controls.Add(this.txtnomproduc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-5, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(567, 163);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTOS";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.DarkGray;
            this.txtprecio.Location = new System.Drawing.Point(383, 100);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(113, 20);
            this.txtprecio.TabIndex = 43;
            // 
            // txtdescripcionproduc
            // 
            this.txtdescripcionproduc.BackColor = System.Drawing.Color.DarkGray;
            this.txtdescripcionproduc.Location = new System.Drawing.Point(324, 36);
            this.txtdescripcionproduc.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripcionproduc.Multiline = true;
            this.txtdescripcionproduc.Name = "txtdescripcionproduc";
            this.txtdescripcionproduc.Size = new System.Drawing.Size(219, 18);
            this.txtdescripcionproduc.TabIndex = 42;
            // 
            // txtnomproduc
            // 
            this.txtnomproduc.BackColor = System.Drawing.Color.DarkGray;
            this.txtnomproduc.Location = new System.Drawing.Point(32, 36);
            this.txtnomproduc.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomproduc.Name = "txtnomproduc";
            this.txtnomproduc.Size = new System.Drawing.Size(247, 20);
            this.txtnomproduc.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 11F);
            this.label2.Location = new System.Drawing.Point(397, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 11F);
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "NOMBRE PRODUCTO";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(-10, -1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(756, 45);
            this.label4.TabIndex = 55;
            this.label4.Text = "FORMULARIO PRODUCTOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_dae.Properties.Resources.imagen_compra;
            this.pictureBox1.Location = new System.Drawing.Point(565, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::proyecto_dae.Properties.Resources.sin_fondo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 279);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 59);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // btnmiminizar
            // 
            this.btnmiminizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmiminizar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnmiminizar.BackgroundImage = global::proyecto_dae.Properties.Resources.minimazar;
            this.btnmiminizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmiminizar.Location = new System.Drawing.Point(705, 8);
            this.btnmiminizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnmiminizar.Name = "btnmiminizar";
            this.btnmiminizar.Size = new System.Drawing.Size(23, 23);
            this.btnmiminizar.TabIndex = 62;
            this.btnmiminizar.TabStop = false;
            this.btnmiminizar.Click += new System.EventHandler(this.btnmiminizar_Click);
            // 
            // Frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(737, 427);
            this.Controls.Add(this.btnmiminizar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridproducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frmproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmproductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproducto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmiminizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridproducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnsalirr;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdescripcionproduc;
        private System.Windows.Forms.TextBox txtnomproduc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnmiminizar;
    }
}