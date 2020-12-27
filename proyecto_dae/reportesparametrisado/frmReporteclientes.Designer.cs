namespace proyecto_dae.reportes
{
    partial class frmReporteclientes
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptclienteparametrisado2 = new proyecto_dae.reportesparametrisado.rptclienteparametrisado();
            this.rptreporteusuarios1 = new proyecto_dae.reportesparametrisado.rptreporteusuarios();
            this.rptclienteparametrisado1 = new proyecto_dae.reportesparametrisado.rptclienteparametrisado();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalirr = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            this.txtBuscasrtex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barradetitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-4, 188);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptclienteparametrisado2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1133, 594);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalirr);
            this.groupBox1.Controls.Add(this.btngenerar);
            this.groupBox1.Controls.Add(this.txtBuscasrtex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(475, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR INFORMACION";
            // 
            // btnsalirr
            // 
            this.btnsalirr.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnsalirr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnsalirr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnsalirr.Image = global::proyecto_dae.Properties.Resources.back_24x24_32;
            this.btnsalirr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirr.Location = new System.Drawing.Point(449, 43);
            this.btnsalirr.Name = "btnsalirr";
            this.btnsalirr.Size = new System.Drawing.Size(131, 38);
            this.btnsalirr.TabIndex = 45;
            this.btnsalirr.Text = "Salir";
            this.btnsalirr.UseVisualStyleBackColor = false;
            this.btnsalirr.Click += new System.EventHandler(this.btnsalirr_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btngenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btngenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btngenerar.Image = global::proyecto_dae.Properties.Resources.search_add_24x24_32;
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerar.Location = new System.Drawing.Point(377, 42);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(48, 38);
            this.btngenerar.TabIndex = 4;
            this.btngenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // txtBuscasrtex
            // 
            this.txtBuscasrtex.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscasrtex.Location = new System.Drawing.Point(141, 43);
            this.txtBuscasrtex.Multiline = true;
            this.txtBuscasrtex.Name = "txtBuscasrtex";
            this.txtBuscasrtex.Size = new System.Drawing.Size(203, 37);
            this.txtBuscasrtex.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR";
            // 
            // barradetitulo
            // 
            this.barradetitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barradetitulo.BackColor = System.Drawing.Color.DarkBlue;
            this.barradetitulo.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Italic);
            this.barradetitulo.ForeColor = System.Drawing.Color.White;
            this.barradetitulo.Location = new System.Drawing.Point(-11, -6);
            this.barradetitulo.Margin = new System.Windows.Forms.Padding(0);
            this.barradetitulo.Name = "barradetitulo";
            this.barradetitulo.Size = new System.Drawing.Size(1164, 71);
            this.barradetitulo.TabIndex = 15;
            this.barradetitulo.Text = "REPORTE DE CLIENTES";
            this.barradetitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.barradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barradetitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::proyecto_dae.Properties.Resources.sin_fondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 114);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmReporteclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1137, 781);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barradetitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteclientes";
            this.Text = "Reporte Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalirr;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.TextBox txtBuscasrtex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label barradetitulo;
        private reportesparametrisado.rptclienteparametrisado rptclienteparametrisado1;
        private reportesparametrisado.rptreporteusuarios rptreporteusuarios1;
        private reportesparametrisado.rptclienteparametrisado rptclienteparametrisado2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}