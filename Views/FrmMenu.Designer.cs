namespace PedidoOnline.Views
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnClientes;
        private Button btnProductos;
        private Button btnPedidos;
        private Button btnSalir;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnClientes = new Button();
            this.btnProductos = new Button();
            this.btnPedidos = new Button();
            this.btnSalir = new Button();
            this.lblTitulo = new Label();

            this.SuspendLayout();

            // Diseño común para todos los botones
            Font fuenteBoton = new Font("Segoe UI", 10F, FontStyle.Regular);
            int ancho = 200;
            int alto = 40;
            int margen = 10;
            int x = 50;
            int y = 120;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Gestor de Pedidos";
            this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(30, 30);
            this.lblTitulo.Size = new Size(240, 40);
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // btnClientes
            // 
            this.btnClientes.Text = "📋 Clientes";
            this.btnClientes.Font = fuenteBoton;
            this.btnClientes.Size = new Size(ancho, alto);
            this.btnClientes.Location = new Point(x, y);
            this.btnClientes.BackColor = Color.LightSkyBlue;
            this.btnClientes.FlatStyle = FlatStyle.Flat;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.Click += new EventHandler(this.btnClientes_Click);

            // 
            // btnProductos
            // 
            this.btnProductos.Text = "📦 Productos";
            this.btnProductos.Font = fuenteBoton;
            this.btnProductos.Size = new Size(ancho, alto);
            this.btnProductos.Location = new Point(x, y + (alto + margen) * 1);
            this.btnProductos.BackColor = Color.LightSkyBlue;
            this.btnProductos.FlatStyle = FlatStyle.Flat;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.Click += new EventHandler(this.btnProductos_Click);

            // 
            // btnPedidos
            // 
            this.btnPedidos.Text = "🧾 Pedidos";
            this.btnPedidos.Font = fuenteBoton;
            this.btnPedidos.Size = new Size(ancho, alto);
            this.btnPedidos.Location = new Point(x, y + (alto + margen) * 2);
            this.btnPedidos.BackColor = Color.LightSkyBlue;
            this.btnPedidos.FlatStyle = FlatStyle.Flat;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.Click += new EventHandler(this.btnPedidos_Click);

            // 
            // btnSalir
            // 
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.Font = fuenteBoton;
            this.btnSalir.Size = new Size(ancho, alto);
            this.btnSalir.Location = new Point(x, y + (alto + margen) * 4);
            this.btnSalir.BackColor = Color.IndianRed;
            this.btnSalir.FlatStyle = FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Click += new EventHandler(this.btnSalir_Click);

            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.ClientSize = new Size(300, 400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnSalir);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.DodgerBlue; // Fondo azul
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
        }
    }
}
