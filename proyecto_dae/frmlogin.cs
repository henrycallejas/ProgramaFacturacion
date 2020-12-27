using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//sql conexion
using System.Data.SqlClient;
using proyecto_dae.formularios;


namespace proyecto_dae
{
    public partial class frmlogin : Form
    {
        SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7();
        Usuarios u = new Usuarios();
        public frmlogin()
        {
            InitializeComponent();

            //Mostrar Fecha y Hora
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void limpiar()
        {
            txtuser.Clear();
            txtPassword.Clear();
        }


        public void logeo(string usuario, string contrasena)
        {
            validarUsuario();
            if (u.tipoUsuario == "Administrador")
            {
                this.Hide();
                Frmbienvenidos bien = new Frmbienvenidos();
                bien.ShowDialog();
                Frmmenuprincipal me = new Frmmenuprincipal();
                me.Show();
            }
            else if (u.tipoUsuario == "Cajero")
            {
                this.Hide();
                //Frmbienvenidos bien = new Frmbienvenidos();
                //bien.ShowDialog();
                FacturacionForm fact = new FacturacionForm(u);
                fact.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña Incorrecta");
            }
        }

        private void validarUsuario()
        {
            var uEncontrado = contexto.Usuarios.Where(us => us.usuario == this.txtuser.Text && us.contraseña == this.txtPassword.Text);
            u = uEncontrado.FirstOrDefault();
        }

        private void pictureingresar_Click(object sender, EventArgs e)
        {
            logeo(this.txtuser.Text, this.txtPassword.Text);
           
        }

       

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkmostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmostrarPass.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
        //efecto al boton ingresar
        private void pictureingresar_MouseHover(object sender, EventArgs e)
        {
            pictureingresar.Size = new Size(100, 95);
        }

        private void pictureingresar_MouseLeave(object sender, EventArgs e)
        {
            pictureingresar.Size = new Size(90, 75);
        }

        private void btncerrar_MouseHover(object sender, EventArgs e)
        {
            btncerrar.Size = new Size(37, 33);
        }
      

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.Size = new Size(35, 30);
        }
        //miminizar login
        private void btnmiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //TERMINA EFECTO
    }
}
