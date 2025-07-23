using MySql.Data.MySqlClient;
using PedidoOnline.Models;
using System;
using System.Collections.Generic;

namespace PedidoOnline.Controllers
{
    public class PedidoController
    {
        // Método para obtener todos los pedidos
        public List<Pedido> ObtenerTodos()
        {
            var lista = new List<Pedido>();
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new MySqlCommand(@"SELECT p.ID, p.ID_Cliente, c.Nombre AS NombreCliente, p.Fecha, p.Estado, p.Pagado, p.ID_Producto, pr.Nombre AS NombreProducto, pr.Precio
                                            FROM Pedido p
                                            JOIN Producto pr ON p.ID_Producto = pr.ID
                                            JOIN Cliente c ON p.ID_Cliente = c.ID", cn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Pedido
                        {
                            ID = dr.GetInt32("ID"),
                            ID_Cliente = dr.GetInt32("ID_Cliente"),
                            NombreCliente = dr.IsDBNull(dr.GetOrdinal("NombreCliente")) ? null : dr.GetString("NombreCliente"),
                            Fecha = dr.GetDateTime("Fecha"),
                            Estado = dr.IsDBNull(dr.GetOrdinal("Estado")) ? null : dr.GetString("Estado"),
                            Pagar = dr.GetBoolean("Pagado"),
                            ProductoID = dr.GetInt32("ID_Producto"),
                            NombreProducto = dr.IsDBNull(dr.GetOrdinal("NombreProducto")) ? null : dr.GetString("NombreProducto"),
                            Precio = dr.GetDecimal("Precio")  // Asegúrate de obtener el precio
                        });
                    }
                }
            }
            return lista;
        }

        // Método para crear un nuevo pedido
        public void Crear(Pedido p)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                // Verificar si el cliente existe
                var cmdVerificarCliente = new MySqlCommand("SELECT COUNT(*) FROM cliente WHERE ID = @c", cn);
                cmdVerificarCliente.Parameters.AddWithValue("@c", p.ID_Cliente);
                var existeCliente = Convert.ToInt32(cmdVerificarCliente.ExecuteScalar());

                if (existeCliente == 0)
                {
                    throw new Exception("El cliente con ID especificado no existe.");
                }

                // Verificar si el producto existe
                var cmdVerificarProducto = new MySqlCommand("SELECT COUNT(*) FROM producto WHERE ID = @p", cn);
                cmdVerificarProducto.Parameters.AddWithValue("@p", p.ProductoID);
                var existeProducto = Convert.ToInt32(cmdVerificarProducto.ExecuteScalar());

                if (existeProducto == 0)
                {
                    throw new Exception("El producto con ID especificado no existe.");
                }

                // Insertar el pedido
                var cmd = new MySqlCommand("INSERT INTO Pedido (ID_Cliente, Fecha, Estado, Pagado, ID_Producto) VALUES (@c, @f, @estado, @pagado, @p)", cn);
                cmd.Parameters.AddWithValue("@c", p.ID_Cliente);
                cmd.Parameters.AddWithValue("@f", p.Fecha);
                cmd.Parameters.AddWithValue("@estado", p.Estado ?? "Pendiente");
                cmd.Parameters.AddWithValue("@pagado", p.Pagar);
                cmd.Parameters.AddWithValue("@p", p.ProductoID);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para actualizar un pedido existente
        public void Actualizar(Pedido p)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                // Verificar si el cliente existe
                var cmdVerificarCliente = new MySqlCommand("SELECT COUNT(*) FROM cliente WHERE ID = @c", cn);
                cmdVerificarCliente.Parameters.AddWithValue("@c", p.ID_Cliente);
                var existeCliente = Convert.ToInt32(cmdVerificarCliente.ExecuteScalar());

                if (existeCliente == 0)
                {
                    throw new Exception("El cliente con ID especificado no existe.");
                }

                // Verificar si el producto existe
                var cmdVerificarProducto = new MySqlCommand("SELECT COUNT(*) FROM producto WHERE ID = @p", cn);
                cmdVerificarProducto.Parameters.AddWithValue("@p", p.ProductoID);
                var existeProducto = Convert.ToInt32(cmdVerificarProducto.ExecuteScalar());

                if (existeProducto == 0)
                {
                    throw new Exception("El producto con ID especificado no existe.");
                }

                // Actualizar el pedido
                var cmd = new MySqlCommand("UPDATE Pedido SET ID_Cliente = @c, Fecha = @f, Estado = @estado, Pagado = @pagado, ID_Producto = @p WHERE ID = @id", cn);
                cmd.Parameters.AddWithValue("@id", p.ID);
                cmd.Parameters.AddWithValue("@c", p.ID_Cliente);
                cmd.Parameters.AddWithValue("@f", p.Fecha);
                cmd.Parameters.AddWithValue("@estado", p.Estado ?? "Pendiente");
                cmd.Parameters.AddWithValue("@pagado", p.Pagar);
                cmd.Parameters.AddWithValue("@p", p.ProductoID);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para pagar un pedido
        public void Pagar(int id)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new MySqlCommand("UPDATE Pedido SET Estado = 'Pagado' WHERE ID = @id", cn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un pedido
        public void Eliminar(int id)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                var cmd = new MySqlCommand("DELETE FROM Pedido WHERE ID = @id", cn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
