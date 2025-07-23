namespace PedidoOnline.Models
{
    public class Pedido
    {
        public int ID { get; set; }           // Identificador único del pedido
        public int ID_Cliente { get; set; }   // Clave foránea con Cliente
        public string NombreCliente { get; set; } // Nombre cliente para mostrar en la interfaz
        public DateTime Fecha { get; set; }   // Fecha del pedido
        public string Estado { get; set; }    // Estado del pedido (Pendiente, Pagado, etc.)
        public bool Pagar { get; set; }       // Indica si el pedido ha sido pagado
        public int ProductoID { get; set; }   // Identificador del producto asociado al pedido
        public string NombreProducto { get; set; } // Nombre del producto para mostrar en la interfaz
        public decimal Precio { get; set; }   // Precio del producto asociado al pedido


        // Relación con Cliente
        public virtual Cliente Cliente { get; set; }  // Relación con el cliente

        // Relación con Producto
        public virtual Producto Producto { get; set; }  // Relación con el producto seleccionado

        // Relación con los detalles de los productos
     
    }
}
