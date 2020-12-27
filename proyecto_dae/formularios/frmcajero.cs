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
    public partial class frmcajero : Form
    {
        // para mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        //  conexion a mi base de datos
        SistemaFacturacionPruebaEntities7 conexion = new SistemaFacturacionPruebaEntities7();
        Cajero caje = new Cajero();

        // Para saber que opcion guardar nuevo o modificar
        string opcion = "";

        public frmcajero()
        {
            InitializeComponent();

            dataGridcajero.DataSource = conexion.Cajero.ToList();

           desactivar_control();

            //comboBox para el buscador
            comboBox1.Items.Add("nombreCajero");
            comboBox1.Items.Add("DUIcajero");
            comboBox1.Items.Add("idUsuario_fk");
            cmbUsuarios.DataSource = conexion.Usuarios.ToList();
            cmbUsuarios.DisplayMember = "usuario";
            cmbUsuarios.ValueMember = "idUsuario_pk";
        }


        // Cargar los datos en el grip para el buscador
        private void cargar()
        {
            dataGridcajero.DataSource = conexion.Cajero.ToList();
        }

        // desactivar los controles 


        public void desactivar_control()
        {
            txtnombrecajero.Enabled = false;
            txtduicajero.Enabled = false;
        }

        // activar los controles 
        public void activar_control()
        {
            txtnombrecajero.Enabled = true;
            txtduicajero.Enabled = true;
        }


        //limpiar
        public void limpiar()
        {
            txtnombrecajero.Clear();
            txtduicajero.Clear();

            //para el buscador
            txtbuscar.Clear();
            comboBox1.Text = "";
        }

        //Carga los datos
        private void setcargar()
        {
            caje.nombreCajero = txtnombrecajero.Text;
            caje.DUIcajero = txtduicajero.Text;
            caje.idUsuario_fk = int.Parse(cmbUsuarios.SelectedValue.ToString());
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            setcargar();
            if (opcion.Equals("nuevo"))
            {
                conexion.Cajero.Add(caje);
                conexion.SaveChanges();
                limpiar();
                desactivar_control();
                cargar();
                MessageBox.Show("Exito");

            }else if (opcion.Equals("Modificar"))
            {
                int id = int.Parse(dataGridcajero.SelectedRows[0].Cells[0].Value.ToString());
                Cajero cajero = conexion.Cajero.FirstOrDefault(c => c.idCajero_pk == id);
                cajero.nombreCajero = caje.nombreCajero;
                cajero.DUIcajero = caje.DUIcajero;
                cajero.idUsuario_fk = caje.idUsuario_fk;
                conexion.SaveChanges();
                limpiar();
                desactivar_control();
                cargar();
                MessageBox.Show("Exito");
            }
            else
            {
                MessageBox.Show("Nada que modificar");
            }
        }

      

        private void btnmodi_Click(object sender, EventArgs e)
        {
            opcion = "Modificar";
            activar_control();
        }

        private void dataGridcajero_Click(object sender, EventArgs e)
        {
            txtnombrecajero.Text = dataGridcajero.SelectedRows[0].Cells[3].Value.ToString();
            txtduicajero.Text = dataGridcajero.SelectedRows[0].Cells[2].Value.ToString();
            cmbUsuarios.SelectedValue = int.Parse(dataGridcajero.SelectedRows[0].Cells[1].Value.ToString());
        }

        private void btneli_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridcajero.SelectedRows[0].Cells[0].Value.ToString());
            using (SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7())
            {
                try
                {
                    DialogResult elimin = MessageBox.Show("¿Desea Eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (elimin == DialogResult.Yes)
                    {
                        Cajero c = contexto.Cajero.FirstOrDefault(x => x.idCajero_pk == id);
                        contexto.Cajero.Remove(c);
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
            dataGridcajero.DataSource = conexion.Cajero.SqlQuery("Select * from Cajero where " + campo + " like'%" + criterio + "%'").ToList();
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
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            frmReportecajero caje = new frmReportecajero();
            caje.ShowDialog();
        }
        //boton 
        private void btnmiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //para mover el panel

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            opcion = "nuevo";
            activar_control();
        }
    }
}
