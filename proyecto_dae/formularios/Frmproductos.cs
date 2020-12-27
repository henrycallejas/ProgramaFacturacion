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

using proyecto_dae.reportesparametrisado;
namespace proyecto_dae.formularios
{
    public partial class Frmproductos : Form
    {
        // para mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7();
        Producto productos = new Producto();

        // Para saber que opcion guardar nuevo o modificar
        string opcion = "";

        public Frmproductos()
        {
            InitializeComponent();
            dataGridproducto.DataSource = contexto.Producto.ToList();
            desactivar_control();



            //comboBox para el buscador
            comboBox1.Items.Add("nombreProducto");
            comboBox1.Items.Add("idProducto");
        }

        private void cargar()
        {
            dataGridproducto.DataSource = contexto.Producto.ToList();
        }

        public void desactivar_control()
        {
            txtnomproduc.Enabled = false;
            txtdescripcionproduc.Enabled = false;
            txtprecio.Enabled = false;
        }

        public void activar_control()
        {
            txtnomproduc.Enabled = true;
            txtdescripcionproduc.Enabled = true;
            txtprecio.Enabled = true;
        }

        public void limpiar()
        {
            txtnomproduc.Clear();
            txtdescripcionproduc.Clear();
            txtprecio.Clear();

            //para el buscador
            txtbuscar.Clear();
            comboBox1.Text = "";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            activar_control();
            limpiar();
            opcion = "Nuevo";
            cargar();
        }



        private void setcargar()
        {
            
            productos.nombreProducto = txtnomproduc.Text;
            productos.descripcion = txtdescripcionproduc.Text;
            productos.precioUnitario = double.Parse(txtprecio.Text);
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            setcargar();
            if (opcion.Equals("Nuevo"))
            {
                contexto.Producto.Add(productos);
                contexto.SaveChanges();
                limpiar();
                desactivar_control();
                cargar();
                MessageBox.Show("Exito");

            }
            else if (opcion.Equals("Modificar"))
            {
                int id = int.Parse(dataGridproducto.SelectedRows[0].Cells[0].Value.ToString());
                //extrallendo registro
                Producto p = contexto.Producto.FirstOrDefault(x => x.idProducto_pk == id);
                //aplicando la modificasion

                try
                {
                    DialogResult modi = MessageBox.Show("¿Desea modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modi == DialogResult.Yes)
                    {
                        p.nombreProducto = productos.nombreProducto;
                        p.descripcion = productos.descripcion;
                        p.precioUnitario = productos.precioUnitario;
                        contexto.SaveChanges();
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

        private void btnmodi_Click(object sender, EventArgs e)
        {
            opcion = "Modificar";
            activar_control();
        }

        private void dataGridproducto_Click(object sender, EventArgs e)
        {
            txtnomproduc.Text = dataGridproducto.SelectedRows[0].Cells[1].Value.ToString();
            txtdescripcionproduc.Text = dataGridproducto.SelectedRows[0].Cells[2].Value.ToString();
            txtprecio.Text = dataGridproducto.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btneli_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridproducto.SelectedRows[0].Cells[0].Value.ToString());
            using (SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7())
            {
                try
                {
                    DialogResult elimin = MessageBox.Show("¿Desea Eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (elimin == DialogResult.Yes)
                    {
                        Producto r = contexto.Producto.FirstOrDefault(x => x.idProducto_pk == id);
                        contexto.Producto.Remove(r);
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

        private void btnsalirr_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea Salir y volver al menu principal?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Para buscar

        private void filtrar(string criterio, string campo)
        {
            dataGridproducto.DataSource = contexto.Producto.SqlQuery("Select * from Producto where " + campo + " like'%" + criterio + "%'").ToList();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            filtrar(txtbuscar.Text, comboBox1.Text);
            limpiar();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            dataGridproducto.DataSource = contexto.Producto.ToList();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Frmproductosparametrisado reporte = new Frmproductosparametrisado();
            reporte.Show();

        }
        //boton
        private void btnmiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        // para mover el panel
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
