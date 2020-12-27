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
    public partial class Frmmenuprincipal : Form
    {
        // para mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public Frmmenuprincipal()
        {
            InitializeComponent();
        }


        //para poder mover la barra de titulo si se miminiza
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //botones principales 

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
        //fin de botones principales 

        //para que se pueda miminizar los formularios 

        private void abrirenpanel(object Frmclientes)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = Frmclientes as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void abrirenpanel1(object Frmproductos)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = Frmproductos as Form; //formulario productos
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void abrirenpanel2(object Frmusuarios)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = Frmusuarios as Form; //formulario productos
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void abrirenpanel3(object frmcajero)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = frmcajero as Form; //formulario productos
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void abrirenpanel4(object frmacercade)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = frmacercade as Form; //formulario acerca de 
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }



        //menu principal 

        //yame cada instancia para poder miminizar cada formulario dentro del formulario padre 

        private void button1_Click(object sender, EventArgs e)
        {

            abrirenpanel(new Frmclientes());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirenpanel1(new Frmproductos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirenpanel2(new Frmusuarios());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirenpanel3(new frmcajero());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirenpanel4(new frmacercade());
        }
    }
}
