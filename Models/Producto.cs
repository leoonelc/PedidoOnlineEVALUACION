namespace PedidoOnline.Models
{
    public class Producto
    {
        public int ID { get; set; }      // Identificador único del producto
        public string Nombre { get; set; }  // Nombre del producto
        public decimal Precio { get; set; }  // Precio del producto
        public int Stock { get; set; }    // Cantidad de stock disponible

        // Puedes agregar otros detalles del producto si lo necesitas
    }
}
