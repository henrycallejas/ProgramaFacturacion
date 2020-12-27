using proyecto_dae.reportes;
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
    public partial class Frmclientes : Form
    {
        // para mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //  conexion a mi base de datos
        SistemaFacturacionPruebaEntities7 conexion = new SistemaFacturacionPruebaEntities7();
        Cliente clien = new Cliente();

        // Para saber que opcion guardar nuevo o modificar
        string opcion = "";

        public Frmclientes()
        {
            InitializeComponent();
            dataGridcliente.DataSource = conexion.Cliente.ToList();

            desactivar_control();
            //comboBox para el buscador
            comboBox1.Items.Add("nombreCliente");
            comboBox1.Items.Add("DUI");

        }


        // Cargar los datos en el grip para el buscador
        private void cargar()
        {
            dataGridcliente.DataSource = conexion.Cliente.ToList();
        }

        // desactivar los controles 


        public void desactivar_control()
        {
            txtnomcliente.Enabled = false;
            txtduiclien.Enabled = false;
            txtclientnit.Enabled = false;
            txtnrc.Enabled = false;
        }

        // activar los controles 
        public void activar_control()
        {
            txtnomcliente.Enabled = true;
            txtduiclien.Enabled = true;
            txtclientnit.Enabled = true;
            txtnrc.Enabled = true;
        }


        //limpiar
        public void limpiar()
        {
            txtnomcliente.Clear();
            txtduiclien.Clear();
            txtclientnit.Clear();
            txtnrc.Clear();

            //para el buscador
            txtbuscar.Clear();
            comboBox1.Text = "";
        }

        //Carga los datos
        private void setcargar()
        {
            
            clien.nombreCliente = txtnomcliente.Text;
            clien.DUI = txtduiclien.Text;
            clien.NIT = txtclientnit.Text;
            clien.NRC = txtnrc.Text;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            setcargar();
            if (opcion.Equals("Nuevo"))
            {
                conexion.Cliente.Add(clien);
                conexion.SaveChanges();
                limpiar();
                desactivar_control();
                cargar();
                MessageBox.Show("Exito");

            }
            else if (opcion.Equals("Modificar"))
            {
                int id = int.Parse(dataGridcliente.SelectedRows[0].Cells[0].Value.ToString());
                //extrallendo registro
                Cliente p = conexion.Cliente.FirstOrDefault(x => x.idCliente_pk == id);
                //aplicando la modificasion

                try
                {
                    DialogResult modi = MessageBox.Show("¿Desea modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modi == DialogResult.Yes)
                    {
                        p.nombreCliente = clien.nombreCliente;
                        p.DUI = clien.DUI;
                        p.NIT = clien.NIT;
                        p.NRC = clien.NRC;
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

        private void dataGridcliente_Click(object sender, EventArgs e)
        {
            txtnomcliente.Text = dataGridcliente.SelectedRows[0].Cells[1].Value.ToString();
            txtduiclien.Text = dataGridcliente.SelectedRows[0].Cells[2].Value.ToString();
            txtclientnit.Text = dataGridcliente.SelectedRows[0].Cells[3].Value.ToString();
            txtnrc.Text = dataGridcliente.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btneli_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridcliente.SelectedRows[0].Cells[0].Value.ToString());
            using (SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7())
            {
                try
                {
                    DialogResult elimin = MessageBox.Show("¿Desea Eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (elimin == DialogResult.Yes)
                    {
                        Cliente c = contexto.Cliente.FirstOrDefault(x => x.idCliente_pk == id);
                        contexto.Cliente.Remove(c);
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
            dataGridcliente.DataSource = conexion.Cliente.SqlQuery("Select * from Cliente where " + campo + " like'%" + criterio + "%'").ToList();
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
            frmReporteclientes clien = new frmReporteclientes();
            clien.ShowDialog();
        }
        // botones

        private void btnmiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //mover el panel
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //fin de botones //



    }
}
