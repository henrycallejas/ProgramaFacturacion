using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace proyecto_dae.formularios
{
    public partial class FacturacionForm : Form
    {
        SistemaFacturacionPruebaEntities7 contexto = new SistemaFacturacionPruebaEntities7();
        Producto pro = new Producto();
        Factura fact = new Factura();
        Cliente cliente = new Cliente();

        Usuarios u;
        double total = 0;
        public FacturacionForm(Usuarios us)
        {
            InitializeComponent();
            inicializarDataGrid();
            cargarCombos();
            calcularFechayHora();
            this.u = us;
            txtCajero.Text = saberQueCajeroes().nombreCajero;
            deshabilitar();
        }

        //Inicializa el data grid detalle de productos y le asigna nombres a las columnas que tendrá por defecto
        private void inicializarDataGrid()
        {
            dataDetalles.ColumnCount = 4;
            dataDetalles.ColumnHeadersVisible = true;
            dataDetalles.Columns[0].Name = "Nombre Producto";
            dataDetalles.Columns[1].Name = "Cantidad";
            dataDetalles.Columns[2].Name = "Precio Unitario";
            dataDetalles.Columns[3].Name = "Subtotal";
            dataDetalles.ForeColor = Color.Black;
        }

        //Deshabilita los campos, botones y combobox hasta que se verifique el cliente
        private void deshabilitar()
        {
            txtNombreCliente.Enabled = false;
            txtDUI.Enabled = false;
            txtNIT.Enabled = false;
            txtNRC.Enabled = false;
            txtBuscar.Enabled = false;
            btnGenerarFactura.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtSubtotal.Enabled = false;
            cmbProductos.Enabled = false;
            btnAgregar.Enabled = false;
            cmbComprobante.Enabled = false;
            cmbMetodoPago.Enabled = false;
            txtFecha.Enabled = false;
            txtCajero.Enabled = false;
        }

        private void habilitar()
        {
            txtNombreCliente.Enabled = true;
            txtDUI.Enabled = true;
            txtNIT.Enabled = true;
            txtNRC.Enabled = true;
            txtBuscar.Enabled = true;
            txtCantidad.Enabled = true;
            //txtPrecio.Enabled = true;
            //txtSubtotal.Enabled = true;
            cmbProductos.Enabled = true;
            btnAgregar.Enabled = true;
            cmbComprobante.Enabled = true;
            cmbMetodoPago.Enabled = true;
        }

        //Procedimiento que habilita el botón de generar factura
        private void habilitarFactura()
        {
            btnGenerarFactura.Enabled = true;
        }

        //Método que va calculando el total de la factura
        private void calcularTotal()
        {
            total += double.Parse(txtSubtotal.Text);
            labelTotal.Text = total.ToString();
        }

        //Método que se llama cuando se elimina un producto del datagrid, el producto que se elimina se resta del total
        private void restarEliminado()
        {
            if(dataDetalles.SelectedRows[0].Cells[3].Value != null)
            {
                total -= double.Parse(dataDetalles.SelectedRows[0].Cells[3].Value.ToString());
                labelTotal.Text = total.ToString();
            }
        }

        //Método que recorre el datagrid de detalles de productos para ir agregando cada producto a la base de datos
        private void recorrerDataGrid(Factura fact)
        {
            string nombreProd = "";
            DetalleFactura detalle = new DetalleFactura();
            foreach (DataGridViewRow fila in dataDetalles.Rows)
            {
                if (fila.Cells["Nombre Producto"].Value != null)
                {
                    nombreProd = fila.Cells["Nombre Producto"].Value.ToString();
                    Producto pro = contexto.Producto.Where(p => p.nombreProducto == nombreProd).FirstOrDefault();
                    detalle.cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                    detalle.idProducto_fk = pro.idProducto_pk;
                    detalle.numeroFactura_fk = fact.numeroFactura_pk;
                    contexto.DetalleFactura.Add(detalle);
                    contexto.SaveChanges();
                }

            }
        }

        //Método que se llama cuando se ejecuta el evento click del boton eliminar producto
        private void eliminarProducto()
        {
            if (numeroIndice != -1 && numeroIndice != (dataDetalles.Rows.Count -1))
            {
                restarEliminado();
                MessageBox.Show(numeroIndice.ToString());
                MessageBox.Show(dataDetalles.Rows.Count.ToString());
                dataDetalles.Rows.RemoveAt(numeroIndice);
                numeroIndice = -1;
            }
            else
            {
                MessageBox.Show("Debe dar click a la fila del producto que desea eliminar");
            }
        }

        //Carga todos los combobox con las listas correspondientes
        private void cargarCombos()
        {
            cmbProductos.DataSource = contexto.Producto.ToList();
            cmbProductos.ValueMember = "idProducto_pk";
            cmbProductos.DisplayMember = "nombreProducto";
            cmbMetodoPago.DataSource = contexto.MetodoPago.ToList();
            cmbMetodoPago.ValueMember = "idMetodoPago_pk";
            cmbMetodoPago.DisplayMember = "tipoMetodo";
            cmbComprobante.DataSource = contexto.TipoComprobante.ToList();
            cmbComprobante.ValueMember = "idComprobante_pk";
            cmbComprobante.DisplayMember = "nombreComprobante";
        }

        

//Metodo que calcula el subtotal formula cantidad * precio
private double calcularSubTotal()
        {
            return (int.Parse(txtCantidad.Value.ToString()) * double.Parse(txtPrecio.Text));
        }

        

        private void calcularFechayHora()
        {
            txtFecha.Text = DateTime.Now.ToString();
        }
        //Metodo para saber que cajero esta usando el sistema y que se agregue a la factura al final
        private Cajero saberQueCajeroes()
        {
            return contexto.Cajero.Where(c => c.idUsuario_fk == u.idUsuario_pk).FirstOrDefault();
        }

        //Verifica si exisite el cliente con un DUI ingresado al sistema, sino existe se envia un formulario para que se agregue
        private void verificarCliente()
        {
            cliente = contexto.Cliente.Where(c => c.DUI == txtIngreseDUI.Text).FirstOrDefault();
            if (cliente != null)
            {
                txtDUI.Text = cliente.DUI;
                txtNombreCliente.Text = cliente.nombreCliente;
                txtNIT.Text = cliente.NIT;
                txtNRC.Text = cliente.NRC;
                habilitar();
                txtIngreseDUI.Clear();
            }
            else
            {
                DialogResult res = MessageBox.Show("Cliente no existe, desea agregarlo al sistema?", "Confirmar", MessageBoxButtons.OKCancel);
                if(res == DialogResult.OK)
                {
                    ClienteForm fCliente = new ClienteForm(txtIngreseDUI.Text, this);
                    fCliente.Show();
                }
            }

        }

        public void obtenerClienteDeModal(Cliente cl)
        {
            this.cliente = cl;
            this.cliente.idCliente_pk = cl.idCliente_pk;
            txtNombreCliente.Text = cl.nombreCliente;
            txtDUI.Text = cl.DUI;
            txtNIT.Text = cl.NIT;
            txtNRC.Text = cl.NRC;
            habilitar();
            txtIngreseDUI.Clear();
        }

        //Metodo que genera la factura con todos los datos obligatorios
        private Factura generarFactura()
        {
            if (dataDetalles.Rows.Count < 2) // Si hay menos de 2 filas es porque no ha agragado ningun producto, por defecto hay 1 fila vacia
            {
                MessageBox.Show("No tiene productos agregados");
                return null;
            }
            else
            {
                Factura factura = new Factura();
                fact.fecha = DateTime.Now.ToString();
                fact.idCajero_fk = saberQueCajeroes().idCajero_pk;
                fact.idCliente_fk = cliente.idCliente_pk;
                fact.idComprobante_fk = cmbComprobante.SelectedIndex + 1;
                fact.idMetodoPago_fk = cmbMetodoPago.SelectedIndex + 1;
                factura = contexto.Factura.Add(fact);
                contexto.SaveChanges();
                contexto.Entry(factura).State = EntityState.Added; // Para que no haya conflicto al agregar otra factura
                contexto.Entry(factura).State = EntityState.Detached;
                MessageBox.Show("Facturada generada: " + factura.numeroFactura_pk);
                recorrerDataGrid(factura);
                limpiar();
                return factura;
            }
        }

        private void limpiar()
        {
            dataDetalles.Rows.Clear();
            labelTotal.Text = "";
            txtSubtotal.Clear();
            txtCantidad.Value = 1;
            txtNombreCliente.Clear();
            txtDUI.Clear();
            txtNIT.Clear();
            txtNRC.Clear();
        }


        //EVENTOS CLICK/////////////////////////////////

        //Boton que ejecuta el evento click veriricar cliente
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!txtIngreseDUI.Text.Equals(""))
            {
                verificarCliente();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero de DUI o Nombre");
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            Factura factura = generarFactura();
            if (factura != null && factura.idComprobante_fk == 1)
            {
                FacturaRPT impFactura = new FacturaRPT(factura.numeroFactura_pk);
                impFactura.Show();
            }
            else if(factura != null && factura.idComprobante_fk == 2)
            {
                CCF_RPT ccf = new CCF_RPT(factura.numeroFactura_pk);
                ccf.Show();
            }
            deshabilitar();
            total = 0;
        }


        string[] productos;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Si el campo Subtotal no esta vacio es porque ya encontró un producto por busqueda de código
            //o  se seleccionó un producto del combobox
            //Se crea un array de los datos del producto y se le agrega al datagrid y al final se calcula el total
            if (!txtSubtotal.Text.Equals(""))
            {
                productos = new string[] { cmbProductos.Text, txtCantidad.Text, txtPrecio.Text, txtSubtotal.Text };
                dataDetalles.Rows.Add(productos);
                calcularTotal();
                habilitarFactura();
                txtBuscar.Text = "";
                txtCantidad.Value = 1;
            }
            else
            {
                MessageBox.Show("Por favor agregue un producto");
            }
        }

        //Evento que se ejecuta para eliminar un producto del datagrid de detalles
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }


        private void verFacturasGeneradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturasGeneradas facts = new FacturasGeneradas();
            facts.Show();
        }

        int numeroIndice = -1;
        //Cada click que se haga en una fila del data grid se va guardando el indice en la variable por si el usuario
        // desea eliminar el producto se sepa cual eliminar del datagrid
        private void dataDetalles_Click(object sender, EventArgs e)
        {
            numeroIndice = dataDetalles.SelectedRows[0].Index;
        }

        //OTROS EVENTOS
        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cuando un usuario selecciona un producto del combobox se obtiene el detalle de dicho producto y lo agrega a los textbox
            pro = contexto.Producto.Where(p => p.nombreProducto == cmbProductos.Text).FirstOrDefault();
            if (pro != null)
            {
                txtPrecio.Text = pro.precioUnitario.ToString();
                txtSubtotal.Text = calcularSubTotal().ToString();
            }
        }

        //Evento que verifica si el cliente tiene NRC que no pueda elegir Crédito fiscal sino solo Factura
        private void cmbComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbComprobante.SelectedIndex == 1)
            {
                if (cliente.NRC.Equals("-----") || cliente.NRC.Equals(""))
                {
                    MessageBox.Show("El cliente debe tener un NRC para elegir Comprobante de Crédito Fiscal");
                    cmbComprobante.SelectedIndex = 0;
                }
            }
        }

        //METODO QUE ENCUENTRA EL ID DEL METODO DE PAGO DEL COMBOBOX
        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPago met = contexto.MetodoPago.Where(m => m.tipoMetodo.Equals(cmbMetodoPago.Text)).FirstOrDefault();
            if (met != null)
            {
                met.idMetodoPago_pk.ToString();
            }
        }


        int indiceBusqueda = 0;
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals("") && txtBuscar.Text.Any(x => char.IsNumber(x)))
            {
                indiceBusqueda = int.Parse(txtBuscar.Text);
                pro = contexto.Producto.Find(indiceBusqueda);
                cmbProductos.SelectedItem = pro;
            }
            else
            {
                buscar = txtBuscar.Text;
                cmbProductos.SelectedItem = contexto.Producto.Where(p => p.nombreProducto.StartsWith(buscar)).FirstOrDefault();
            }
        }

        string buscar = "";
        private void cmbProductos_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Evento que se ejecuta cuando cambia el valor del subtotal, actualiza el subtotal cada vez
        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            txtSubtotal.Text = calcularSubTotal().ToString();
        }

        
    }
}
