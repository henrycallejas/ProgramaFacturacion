using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//libreria para mover la ventana
using System.Runtime.InteropServices;


namespace proyecto_dae.formularios
{
    public partial class Frmmenu : Form
    {

        // para mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public Frmmenu()
        {
            InitializeComponent();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnmiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //para poder mover la barra de titulo si se miminiza
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-----------------------------------botones de opciones --------------------------------------//
          private void button1_Click(object sender, EventArgs e)
        {
            Frmclientes client = new Frmclientes();
            client.MdiParent = this;
            client.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Frmproductos produc = new Frmproductos();
            produc.MdiParent = this;
            produc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmusuarios user = new Frmusuarios();
            user.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmcajero caje = new frmcajero();
            caje.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

      


    }
}
