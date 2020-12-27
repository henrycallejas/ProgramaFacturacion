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
    public partial class FacturasGeneradas : Form
    {
        SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7();
        int factura;
        int tipoComprobante = 1;
        public FacturasGeneradas()
        {
            InitializeComponent();
            dataFacturas.DataSource = contexto.Factura.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            encontrarFactura();
        }

        private void dataFacturas_Click(object sender, EventArgs e)
        {
            llenarTxt();
            encontrarFactura();
        }

        private void llenarTxt()
        {
            txtNumFactura.Text = dataFacturas.SelectedRows[0].Cells[0].Value.ToString();
            //txtCliente.Text = dataFacturas.SelectedRows[0].Cells[3].Value.ToString();
            //txtFecha.Text = dataFacturas.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void encontrarFactura()
        {
            factura = int.Parse(txtNumFactura.Text.ToString());
            Factura fact = contexto.Factura.Where(f => f.numeroFactura_pk == factura).FirstOrDefault();
            txtFact.Text = fact.numeroFactura_pk.ToString();
            txtFecha.Text = fact.fecha;
            txtCliente.Text = fact.idCliente_fk.ToString();
            tipoComprobante = fact.idComprobante_fk;

            Cliente c = contexto.Cliente.Find(int.Parse(txtCliente.Text));
            txtC.Text = c.nombreCliente;
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            if(tipoComprobante == 1)
            {
                FacturaRPT fact = new FacturaRPT(int.Parse(txtNumFactura.Text));
                fact.Show();
            }else if(tipoComprobante == 2)
            {
                CCF_RPT ccf = new CCF_RPT(int.Parse(txtNumFactura.Text));
                ccf.Show();
            }
            
        }
    }
}
