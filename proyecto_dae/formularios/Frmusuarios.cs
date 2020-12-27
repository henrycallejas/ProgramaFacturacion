using proyecto_dae.reportesparametrisado;
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
    public partial class Frmusuarios : Form
    {
        // para mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        SistemaFacturacionPruebaEntities7 conexion = new SistemaFacturacionPruebaEntities7();
        Usuarios usuario = new Usuarios();

        // Para saber que opcion guardar nuevo o modificar
        string opcion = "";

        public Frmusuarios()
        {
            InitializeComponent();
            dataGridusuario.DataSource = conexion.Usuarios.ToList();

            desactivar_control();
            cmbtipousuario.Items.Add("Administrador");
            cmbtipousuario.Items.Add("Cajero");
            //comboBox para el buscador
            comboBox1.Items.Add("idUsuario_pk");
            comboBox1.Items.Add("usuario1");

        }

        private void cargar()
        {
            dataGridusuario.DataSource = conexion.Usuarios.ToList();
        }

        public void desactivar_control()
        {
            txtnombreusuario.Enabled = false;
            txtcontra.Enabled = false;
            cmbtipousuario.Enabled = false;
        }

        public void activar_control()
        {
            txtnombreusuario.Enabled = true;
            txtcontra.Enabled = true;

            cmbtipousuario.Enabled = true;
        }

        public void limpiar()
        {
            txtnombreusuario.Clear();
            txtcontra.Clear();

            cmbtipousuario.Text = "";

            //para el buscador
            txtbuscar.Clear();
            comboBox1.Text = "";
        }

        //Carga los datos
        private void setcargar()
        {
            usuario.usuario = txtnombreusuario.Text;
            usuario.contraseña = txtcontra.Text;
            usuario.tipoUsuario = cmbtipousuario.Text;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            setcargar();
            if (opcion.Equals("Nuevo"))
            {
                conexion.Usuarios.Add(usuario);
                conexion.SaveChanges();
                limpiar();
                desactivar_control();
                cargar();
                MessageBox.Show("Exito");

            }
            else if (opcion.Equals("Modificar"))
            {
                int id = int.Parse(dataGridusuario.SelectedRows[0].Cells[0].Value.ToString());
                //extrallendo registro
                Usuarios p = conexion.Usuarios.FirstOrDefault(x => x.idUsuario_pk == id);
                //aplicando la modificasion

                try
                {
                    DialogResult modi = MessageBox.Show("¿Desea modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modi == DialogResult.Yes)
                    {
                        p.usuario = usuario.usuario;
                        p.contraseña = usuario.contraseña;
                        p.tipoUsuario = usuario.tipoUsuario;
                        conexion.SaveChanges();
                        cargar();
                        MessageBox.Show("Exito al modificar");
                        opcion = "";
                        limpiar();
                        desactivar_control();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Nada que modificar");
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            activar_control();
            limpiar();
            opcion = "Nuevo";
            cargar();
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            opcion = "Modificar";
            activar_control();
        }

        private void dataGridusuario_Click(object sender, EventArgs e)
        {
            txtnombreusuario.Text = dataGridusuario.SelectedRows[0].Cells[1].Value.ToString();
            txtcontra.Text = dataGridusuario.SelectedRows[0].Cells[2].Value.ToString();
            cmbtipousuario.Text = dataGridusuario.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btneli_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridusuario.SelectedRows[0].Cells[0].Value.ToString());
            using (SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7())
            {
                try
                {
                    DialogResult elimin = MessageBox.Show("¿Desea Eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (elimin == DialogResult.Yes)
                    {
                        Usuarios c = contexto.Usuarios.FirstOrDefault(x => x.idUsuario_pk == id);
                        contexto.Usuarios.Remove(c);
                        contexto.SaveChanges();
                        cargar();
                    }
                }
                catch (Exception)
                {
                    //dejo en blanco para que en la Excepcion no realice nada 
                }
            }
        }

        private void filtrar(string criterio, string campo)
        {
            dataGridusuario.DataSource = conexion.Usuarios.SqlQuery("Select * from Usuario where " + campo + " like'%" + criterio + "%'").ToList();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            filtrar(txtbuscar.Text, comboBox1.Text);
            limpiar();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnsalirr_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar este formulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            FrmReportesdeusuarios user = new FrmReportesdeusuarios();
            user.ShowDialog();
        }

        private void btnmiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
