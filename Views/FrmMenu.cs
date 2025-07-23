using System;
using System.Windows.Forms;

namespace PedidoOnline.Views
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // Evento para abrir el formulario de Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Cerrar el menú y abrir el formulario de Clientes
            this.Hide();  // Ocultar el formulario de menú
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.FormClosed += (s, args) => this.Show();  // Mostrar el formulario del menú cuando se cierre FrmClientes
            frmClientes.Show();  // Mostrar FrmClientes
        }

        // Evento para abrir el formulario de Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            // Cerrar el menú y abrir el formulario de Productos
            this.Hide();  // Ocultar el formulario de menú
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.FormClosed += (s, args) => this.Show();  // Mostrar el formulario del menú cuando se cierre FrmProductos
            frmProductos.Show();  // Mostrar FrmProductos
        }

        // Evento para abrir el formulario de Pedidos
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            // Cerrar el menú y abrir el formulario de Pedidos
            this.Hide();  // Ocultar el formulario de menú
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.FormClosed += (s, args) => this.Show();  // Mostrar el formulario del menú cuando se cierre FrmPedidos
            frmPedidos.Show();  // Mostrar FrmPedidos
        }

        // Evento para salir de la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Cerrar la aplicación
        }
    }
}
