namespace PedidoOnline.Views
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variable necesaria para controlar los componentes
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar todos los recursos que se están usando.
        /// </summary>
        /// <param name="disposing">Indica si los recursos administrados deben ser eliminados.</param>
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAtrás = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(10, 99);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(840, 250);
            dgvClientes.TabIndex = 0;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 385);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(169, 413);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(250, 27);
            txtDireccion.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(675, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 30);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(675, 406);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 30);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DodgerBlue;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(675, 442);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAtrás
            // 
            btnAtrás.BackColor = Color.DodgerBlue;
            btnAtrás.ForeColor = Color.White;
            btnAtrás.Location = new Point(10, 10);
            btnAtrás.Name = "btnAtrás";
            btnAtrás.Size = new Size(100, 30);
            btnAtrás.TabIndex = 6;
            btnAtrás.Text = "Atrás";
            btnAtrás.UseVisualStyleBackColor = false;
            btnAtrás.Click += btnAtrás_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(10, 53);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(700, 27);
            txtBuscar.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(720, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 30);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.SteelBlue;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(207, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(23, 385);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(23, 413);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 10;
            label2.Text = "Dirección";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 247, 250);
            ClientSize = new Size(872, 481);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnAtrás);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(dgvClientes);
            Name = "FrmClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtrás;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
