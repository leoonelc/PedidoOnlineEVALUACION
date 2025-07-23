namespace PedidoOnline.Views
{
    partial class FrmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            dgvPedidos = new DataGridView();
            cmbCliente = new ComboBox();
            cmbProducto = new ComboBox();
            dtpFecha = new DateTimePicker();
            chkPagado = new CheckBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAtras = new Button();
            lblCliente = new Label();
            lblProducto = new Label();
            lblFecha = new Label();
            lblPagado = new Label();
            lblPrecio = new Label();
            lblTitulo = new Label();
            txtPrecio = new TextBox();
            lblTotalVentas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(47, 86);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(678, 220);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.SelectionChanged += dgvPedidos_SelectionChanged;
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(140, 323);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(280, 28);
            cmbCliente.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(140, 353);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(280, 28);
            cmbProducto.TabIndex = 2;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(140, 383);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(280, 27);
            dtpFecha.TabIndex = 3;
            // 
            // chkPagado
            // 
            chkPagado.AutoSize = true;
            chkPagado.Location = new Point(140, 413);
            chkPagado.Name = "chkPagado";
            chkPagado.Size = new Size(81, 24);
            chkPagado.TabIndex = 4;
            chkPagado.Text = "Pagado";
            chkPagado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DodgerBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(576, 316);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(576, 356);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 29);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DodgerBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(576, 396);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Gray;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(25, 20);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(97, 32);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(50, 326);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 9;
            lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.ForeColor = Color.White;
            lblProducto.Location = new Point(50, 356);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 10;
            lblProducto.Text = "Producto:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(50, 386);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha:";
            // 
            // lblPagado
            // 
            lblPagado.AutoSize = true;
            lblPagado.ForeColor = Color.White;
            lblPagado.Location = new Point(50, 414);
            lblPagado.Name = "lblPagado";
            lblPagado.Size = new Size(62, 20);
            lblPagado.TabIndex = 12;
            lblPagado.Text = "Pagado:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(50, 443);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(213, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 32);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Gestión de Pedidos";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(140, 440);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(280, 27);
            txtPrecio.TabIndex = 14;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Microsoft Sans Serif", 12F);
            lblTotalVentas.ForeColor = Color.White;
            lblTotalVentas.Location = new Point(533, 456);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(183, 25);
            lblTotalVentas.TabIndex = 16;
            lblTotalVentas.Text = "Total Ventas: $0.00";
            // 
            // FrmPedidos
            // 
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(760, 500);
            Controls.Add(lblTitulo);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblPagado);
            Controls.Add(lblFecha);
            Controls.Add(lblProducto);
            Controls.Add(lblCliente);
            Controls.Add(btnAtras);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(chkPagado);
            Controls.Add(dtpFecha);
            Controls.Add(cmbProducto);
            Controls.Add(cmbCliente);
            Controls.Add(dgvPedidos);
            Controls.Add(lblTotalVentas);
            Name = "FrmPedidos";
            Text = "Gestión de Pedidos";
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chkPagado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTotalVentas; // Label for Total Ventas
    }
}
