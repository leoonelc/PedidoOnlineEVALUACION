using PedidoOnline.Controllers;
using PedidoOnline.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PedidoOnline.Views
{
    public partial class FrmClientes : Form
    {
        private ClienteController controlador;
        private ApplicationDbContext context;

        // Variable para saber si se está editando un cliente existente
        private int? clienteIdEnEdicion = null;

        public FrmClientes()
        {
            InitializeComponent();

            // Inicializa el contexto de la base de datos
            context = new ApplicationDbContext();

            // Pasa el contexto al controlador
            controlador = new ClienteController(context);

            CargarClientes();
        }

        // Cargar los clientes en el DataGridView
        private void CargarClientes()
        {
            dgvClientes.DataSource = controlador.ObtenerTodos();
        }

        // Evento para guardar un cliente (nuevo o modificado)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            if (clienteIdEnEdicion.HasValue)
            {
                // Editar cliente existente
                var clienteEditado = new Cliente
                {
                    ID = clienteIdEnEdicion.Value,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text
                };

                controlador.Actualizar(clienteEditado);
                MessageBox.Show("Cliente modificado con éxito.");
            }
            else
            {
                // Crear nuevo cliente
                var nuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text
                };

                controlador.Crear(nuevoCliente);
                MessageBox.Show("Cliente guardado exitosamente.");
            }

            CargarClientes();   // Actualizar la tabla
            LimpiarCampos();    // Limpiar campos y estado
        }

        // Evento para eliminar un cliente
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.Cells["ID"].Value != null)
            {
                int clienteId = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID"].Value);
                controlador.Eliminar(clienteId);
                CargarClientes();
                LimpiarCampos();
            }
        }

        // Evento para seleccionar un cliente del DataGridView
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.Cells["ID"].Value != null)
            {
                clienteIdEnEdicion = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID"].Value);
                txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            }
        }

        // Limpiar los campos de texto y reiniciar el modo edición
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            clienteIdEnEdicion = null;
        }

        // Evento para buscar clientes por nombre
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBuscar.Text.ToLower();
            var resultados = controlador.ObtenerTodos()
                .Where(cliente => cliente.Nombre.ToLower().Contains(termino))
                .ToList();

            // Asigna los resultados filtrados al DataGridView
            dgvClientes.DataSource = resultados;  // Corrige la falta del ; aquí
        }

        // Evento para editar un cliente
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                var clienteEditado = new Cliente
                {
                    ID = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID"].Value),
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text
                };

                controlador.Actualizar(clienteEditado);
                CargarClientes();
                LimpiarCampos();
                MessageBox.Show("Cliente modificado con éxito.");
            }
        }

        // Evento para regresar al menú
        private void btnAtrás_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
