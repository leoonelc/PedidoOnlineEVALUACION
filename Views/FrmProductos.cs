using PedidoOnline.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PedidoOnline.Views
{
    public partial class FrmProductos : Form
    {
        private ProductoController controladorProducto;

        public FrmProductos()
        {
            InitializeComponent();
            controladorProducto = new ProductoController();
            CargarProductos();
        }

        // Cargar todos los productos en el DataGridView
        private void CargarProductos()
        {
            var productos = controladorProducto.ObtenerTodos();
            dgvProductos.DataSource = productos;
        }

        // Crear nuevo producto
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombre.Focus();
            dgvProductos.ClearSelection(); // Desmarcar cualquier fila seleccionada
        }

        // Editar producto (carga datos al formulario)
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int productoId = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value);
                Producto producto = controladorProducto.ObtenerPorID(productoId);

                if (producto != null)
                {
                    txtNombre.Text = producto.Nombre;
                    txtPrecio.Text = producto.Precio.ToString("0.00");
                    txtNombre.Tag = producto.ID; // Guardamos el ID en Tag para usarlo en Guardar
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.");
            }
        }

        // Eliminar producto
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int productoId = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value);
                var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?",
                                                    "Eliminar Producto", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    controladorProducto.Eliminar(productoId);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        // Buscar producto
        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text.ToLower();
            var productosFiltrados = controladorProducto.ObtenerTodos()
                .Where(p => p.Nombre.ToLower().Contains(filtro))
                .ToList();

            dgvProductos.DataSource = productosFiltrados;
        }

        // Guardar producto (nuevo o editar)
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor ingrese un precio válido.");
                return;
            }

            // Si txtNombre.Tag tiene un ID, es una edición
            if (txtNombre.Tag != null)
            {
                int id = (int)txtNombre.Tag;
                var productoExistente = controladorProducto.ObtenerPorID(id);
                if (productoExistente != null)
                {
                    productoExistente.Nombre = txtNombre.Text;
                    productoExistente.Precio = precio;

                    controladorProducto.Actualizar(productoExistente);
                    MessageBox.Show("Producto modificado con éxito.");
                }
            }
            else
            {
                // Es un nuevo producto
                var nuevoProducto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = precio
                };

                controladorProducto.Crear(nuevoProducto);
                MessageBox.Show("Producto guardado exitosamente.");
            }

            CargarProductos();
            LimpiarCampos();
        }

        // Volver al formulario anterior
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        // Limpia campos del formulario
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtNombre.Tag = null;
        }
    }
}
