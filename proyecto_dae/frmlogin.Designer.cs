namespace proyecto_dae
{
    partial class frmlogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.pictureingresar = new System.Windows.Forms.PictureBox();
            this.chkmostrarPass = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmiminizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureingresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.SkyBlue;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtuser.Location = new System.Drawing.Point(186, 166);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtuser.Size = new System.Drawing.Size(373, 37);
            this.txtuser.TabIndex = 1;
            // 
            // btncerrar
            // 
            this.btncerrar.BackgroundImage = global::proyecto_dae.Properties.Resources.btn_cerrar;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrar.Location = new System.Drawing.Point(90, 376);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(52, 46);
            this.btncerrar.TabIndex = 7;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseHover += new System.EventHandler(this.btncerrar_MouseHover);
            // 
            // pictureingresar
            // 
            this.pictureingresar.BackColor = System.Drawing.Color.Transparent;
            this.pictureingresar.BackgroundImage = global::proyecto_dae.Properties.Resources.btn_ingresar;
            this.pictureingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureingresar.Location = new System.Drawing.Point(594, 166);
            this.pictureingresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureingresar.Name = "pictureingresar";
            this.pictureingresar.Size = new System.Drawing.Size(135, 105);
            this.pictureingresar.TabIndex = 8;
            this.pictureingresar.TabStop = false;
            this.pictureingresar.Click += new System.EventHandler(this.pictureingresar_Click);
            this.pictureingresar.MouseLeave += new System.EventHandler(this.pictureingresar_MouseLeave);
            this.pictureingresar.MouseHover += new System.EventHandler(this.pictureingresar_MouseHover);
            // 
            // chkmostrarPass
            // 
            this.chkmostrarPass.AutoSize = true;
            this.chkmostrarPass.BackColor = System.Drawing.Color.SkyBlue;
            this.chkmostrarPass.Location = new System.Drawing.Point(440, 299);
            this.chkmostrarPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkmostrarPass.Name = "chkmostrarPass";
            this.chkmostrarPass.Size = new System.Drawing.Size(157, 24);
            this.chkmostrarPass.TabIndex = 22;
            this.chkmostrarPass.Text = "Mostar Password";
            this.chkmostrarPass.UseVisualStyleBackColor = false;
            this.chkmostrarPass.CheckedChanged += new System.EventHandler(this.chkmostrarPass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.SkyBlue;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.Location = new System.Drawing.Point(186, 247);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(373, 33);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.lblFecha.Location = new System.Drawing.Point(160, 393);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(85, 29);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblHora.Location = new System.Drawing.Point(660, 393);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHora.Size = new System.Drawing.Size(69, 29);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::proyecto_dae.Properties.Resources.sin_fondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(505, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 92);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnmiminizar
            // 
            this.btnmiminizar.BackgroundImage = global::proyecto_dae.Properties.Resources.btn_min;
            this.btnmiminizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmiminizar.Location = new System.Drawing.Point(30, 376);
            this.btnmiminizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmiminizar.Name = "btnmiminizar";
            this.btnmiminizar.Size = new System.Drawing.Size(52, 46);
            this.btnmiminizar.TabIndex = 27;
            this.btnmiminizar.UseVisualStyleBackColor = true;
            this.btnmiminizar.Click += new System.EventHandler(this.btnmiminizar_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto_dae.Properties.Resources.login2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmiminizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkmostrarPass);
            this.Controls.Add(this.pictureingresar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txtuser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureingresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.PictureBox pictureingresar;
        private System.Windows.Forms.CheckBox chkmostrarPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmiminizar;
    }
}

