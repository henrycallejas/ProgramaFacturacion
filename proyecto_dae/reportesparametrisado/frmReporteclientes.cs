using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libreri para mover la ventana
using System.Runtime.InteropServices;

using CrystalDecisions.Shared;

using proyecto_dae.formularios;
using proyecto_dae.reportesparametrisado;

namespace proyecto_dae.reportes
{
    public partial class frmReporteclientes : Form
    {
        // para mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
//aqui termina para mover el panel

        ParameterFields parametros = new ParameterFields();
        //parametro de  de tipo 1 parametro
        ParameterField miparametro = new ParameterField();
        //variable para guardar el valor del parametro
        ParameterDiscreteValue valor = new ParameterDiscreteValue();


        public frmReporteclientes()
        {
            InitializeComponent();
        }

        private void btnsalirr_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btngenerar_Click(object sender, EventArgs e)
        {
            //aignar el valor al parametrto
            miparametro.ParameterValueType = ParameterValueKind.StringParameter;

            //defir como se llama el parametro 
            miparametro.Name = "@nombreCliente";
            //capturar el valor del texto
            valor.Value = txtBuscasrtex.Text;
            //valor del parametro
            miparametro.CurrentValues.Add(valor);
            //agregando a mi parametro a la lista de parametro
            parametros.Add(miparametro);

            //asignando los parametros al reporte (el visor gestiona los parametros para el reporte)
            crystalReportViewer1.ParameterFieldInfo = parametros;

            //asignamos el reporte al visor 
            rptclienteparametrisado reporte = new rptclienteparametrisado();
            crystalReportViewer1.ReportSource = reporte;

        }

        private void barradetitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
