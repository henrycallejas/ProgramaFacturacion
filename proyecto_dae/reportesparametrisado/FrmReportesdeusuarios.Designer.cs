namespace proyecto_dae.reportesparametrisado
{
    partial class FrmReportesdeusuarios
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalirr = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            this.txtBuscasrtex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptreporteusuarios1 = new proyecto_dae.reportesparametrisado.rptreporteusuarios();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-5, -6);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1164, 71);
            this.label4.TabIndex = 16;
            this.label4.Text = "REPORTE DE USUARIOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalirr);
            this.groupBox1.Controls.Add(this.btngenerar);
            this.groupBox1.Controls.Add(this.txtBuscasrtex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(500, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 87);
            this.groupBox1.TabIndex = 17;
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
            this.btnsalirr.Location = new System.Drawing.Point(474, 32);
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
            this.btngenerar.Location = new System.Drawing.Point(388, 31);
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
            this.txtBuscasrtex.Location = new System.Drawing.Point(143, 33);
            this.txtBuscasrtex.Multiline = true;
            this.txtBuscasrtex.Name = "txtBuscasrtex";
            this.txtBuscasrtex.Size = new System.Drawing.Size(203, 37);
            this.txtBuscasrtex.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::proyecto_dae.Properties.Resources.sin_fondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 100);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 185);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptreporteusuarios1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1157, 559);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportesdeusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1162, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesdeusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportesdeusuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalirr;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.TextBox txtBuscasrtex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private rptreporteusuarios rptreporteusuarios1;
    }
}