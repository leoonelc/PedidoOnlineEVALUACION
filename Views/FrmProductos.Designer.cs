namespace PedidoOnline.Views
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblTitulo;

        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtBuscarProducto = new TextBox();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblBuscarProducto = new Label();
            btnNuevoProducto = new Button();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            btnGuardarProducto = new Button();
            btnAtras = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(23, 121);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(759, 200);
            dgvProductos.TabIndex = 1;

            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 337);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 5;

            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(519, 337);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 27);
            txtPrecio.TabIndex = 7;

            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(158, 70);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(624, 27);
            txtBuscarProducto.TabIndex = 3;
            txtBuscarProducto.TextChanged += TxtBuscarProducto_TextChanged;

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 340);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(131, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre Producto:";

            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(446, 340);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";

            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(23, 70);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(119, 20);
            lblBuscarProducto.TabIndex = 2;
            lblBuscarProducto.Text = "Buscar Producto:";

            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.BackColor = Color.DodgerBlue;
            btnNuevoProducto.ForeColor = Color.White;
            btnNuevoProducto.Location = new Point(23, 401);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(150, 32);
            btnNuevoProducto.TabIndex = 8;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = false;
            btnNuevoProducto.Click += btnNuevoProducto_Click;

            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.DodgerBlue;
            btnEditarProducto.ForeColor = Color.White;
            btnEditarProducto.Location = new Point(179, 401);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(150, 32);
            btnEditarProducto.TabIndex = 9;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Click += btnEditarProducto_Click;

            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.DodgerBlue;
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(335, 401);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(150, 32);
            btnEliminarProducto.TabIndex = 10;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;

            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.MidnightBlue;
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(491, 401);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(150, 32);
            btnGuardarProducto.TabIndex = 11;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;

            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Gray;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(647, 401);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(135, 32);
            btnAtras.TabIndex = 12;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;

            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.MidnightBlue;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(158, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Productos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue; // Fondo azul similar al menú
            ClientSize = new Size(826, 454);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Controls.Add(lblBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(btnNuevoProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnGuardarProducto);
            Controls.Add(btnAtras);
            Name = "FrmProductos";
            Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
