using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_dae.formularios
{
    public partial class ClienteForm : Form
    {
        Cliente c = new Cliente();
        SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7();
        string DUI;
        FacturacionForm form;
        public ClienteForm(string DUI, FacturacionForm form)
        {
            InitializeComponent();
            this.DUI = DUI;
            this.txtDUI.Text = DUI;
            this.form = form;
        }

        public Cliente obtenerCliente()
        {
            return c;
        }

        private void cargarTextBox()
        {
            c.DUI = this.DUI;
            c.nombreCliente = txtNombre.Text;
            c.NIT = txtNIT.Text;
            c.NRC = txtNRC.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cargarTextBox();
            contexto.Cliente.Add(c);
            contexto.SaveChanges();
            MessageBox.Show("Cliente agregado exitosamente!");
            this.Close();
        }

        private void ClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.obtenerClienteDeModal(c);
        }
    }
}
