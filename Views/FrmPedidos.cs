using PedidoOnline.Controllers;
using PedidoOnline.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PedidoOnline.Views
{
    public partial class FrmPedidos : Form
    {
        PedidoController controlador = new PedidoController();
        ClienteController clienteController;
        ProductoController productoController = new ProductoController();
        ApplicationDbContext context;

        public FrmPedidos()
        {
            InitializeComponent();

            // Inicializa el contexto de la base de datos
            context = new ApplicationDbContext();

            // Pasa el contexto al controlador de clientes
            clienteController = new ClienteController(context);

            CargarPedidos();
            CargarClientes();
            CargarProductos();
        }

        private void CargarPedidos()
        {
            var pedidos = controlador.ObtenerTodos();

            var lista = pedidos.Select(p => new
            {
                p.ID,
                Cliente = p.NombreCliente,
                Producto = p.NombreProducto,
                p.Fecha,
                p.Estado,
                Pagado = p.Pagar ? "Sí" : "No",
                Precio = p.Precio.ToString("C") // Asegúrate de que el precio esté incluido y formateado
            }).ToList();

            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = lista;

            if (dgvPedidos.Columns["ID"] != null)
                dgvPedidos.Columns["ID"].Visible = false;

            // Calcular el total de ventas
            decimal totalVentas = pedidos.Sum(p => p.Precio);

            // Mostrar el total en el Label
            lblTotalVentas.Text = "Total Ventas: " + totalVentas.ToString("C");
        }

        private void CargarClientes()
        {
            var clientes = clienteController.ObtenerTodos();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ID";
        }

        private void CargarProductos()
        {
            var productos = productoController.ObtenerTodos();
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "ID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = (Producto)cmbProducto.SelectedItem;
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un producto.");
                return;
            }

            string estadoStock = productoSeleccionado.Stock > 0 ? "Disponible" : "No Disponible";

            // Mensaje de confirmación antes de proceder con la transacción
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea proceder con la transacción?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                var pedido = new Pedido
                {
                    ID_Cliente = Convert.ToInt32(cmbCliente.SelectedValue),
                    Fecha = dtpFecha.Value,
                    Estado = estadoStock,
                    ProductoID = productoSeleccionado.ID,
                    NombreProducto = productoSeleccionado.Nombre,
                    Precio = productoSeleccionado.Precio,
                    Pagar = chkPagado.Checked
                };

                controlador.Crear(pedido);
                CargarPedidos();  // Actualizar la grid con el nuevo pedido
                LimpiarCampos();  // Limpiar los campos después de agregar el pedido
                MessageBox.Show("Pedido guardado con éxito.");
            }
            else
            {
                MessageBox.Show("Transacción cancelada.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["ID"].Value);

                var pedidoEditado = new Pedido
                {
                    ID = id,
                    ID_Cliente = Convert.ToInt32(cmbCliente.SelectedValue),
                    Fecha = dtpFecha.Value,
                    Estado = "Actualizado",
                    ProductoID = Convert.ToInt32(cmbProducto.SelectedValue),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Pagar = chkPagado.Checked
                };

                controlador.Actualizar(pedidoEditado);
                CargarPedidos();
                LimpiarCampos();
                MessageBox.Show("Pedido modificado con éxito.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["ID"].Value);
                controlador.Eliminar(id);
                CargarPedidos();
                LimpiarCampos();
            }
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                try
                {
                    var pedidoSeleccionado = controlador.ObtenerTodos().FirstOrDefault(p =>
                        p.ID == Convert.ToInt32(dgvPedidos.CurrentRow.Cells["ID"].Value));

                    if (pedidoSeleccionado != null)
                    {
                        cmbCliente.SelectedValue = pedidoSeleccionado.ID_Cliente;
                        cmbProducto.SelectedValue = pedidoSeleccionado.ProductoID;
                        dtpFecha.Value = pedidoSeleccionado.Fecha;
                        chkPagado.Checked = pedidoSeleccionado.Pagar;
                        txtPrecio.Text = pedidoSeleccionado.Precio.ToString("C");
                    }
                }
                catch
                {
                    // Ignorar errores de asignación
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            chkPagado.Checked = false;
            txtPrecio.Text = string.Empty;
        }

        // Método para manejar el evento de cambio de selección del ComboBox de productos
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem != null)
            {
                // Obtener el producto seleccionado
                Producto productoSeleccionado = (Producto)cmbProducto.SelectedItem;

                // Mostrar el precio en el TextBox
                txtPrecio.Text = productoSeleccionado.Precio.ToString("C"); // Mostrar el precio con formato de moneda
            }
        }
    }
}
