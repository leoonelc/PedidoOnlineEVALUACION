using MySql.Data.MySqlClient;
using PedidoOnline.Models; // Importar el espacio de nombres adecuado
using System;
using System.Collections.Generic;

public class ProductoController
{
    // Obtener todos los productos (para mostrar en DataGridView)
    public List<Producto> ObtenerTodos()
    {
        var lista = new List<Producto>();

        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            var cmd = new MySqlCommand("SELECT * FROM Producto", cn);
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        ID = dr.GetInt32("ID"),
                        Nombre = dr.GetString("Nombre"),
                        Precio = dr.GetDecimal("Precio")
                    });
                }
            }
        }

        return lista;
    }

    // Crear un nuevo producto
    public void Crear(Producto p)
    {
        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            try
            {
                var cmd = new MySqlCommand("INSERT INTO Producto (Nombre, Precio) VALUES (@n, @p)", cn);
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@p", p.Precio);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear producto: " + ex.Message);
            }
        }
    }

    // Actualizar producto existente
    public void Actualizar(Producto p)
    {
        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            try
            {
                var cmd = new MySqlCommand("UPDATE Producto SET Nombre=@n, Precio=@p WHERE ID=@id", cn);
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@p", p.Precio);
                cmd.Parameters.AddWithValue("@id", p.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }
    }

    // Eliminar un producto por ID
    public void Eliminar(int id)
    {
        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            try
            {
                var cmd = new MySqlCommand("DELETE FROM Producto WHERE ID=@id", cn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }
    }

    // Obtener productos para combos o listas (para usar en FrmDetallePedido, etc.)
    public List<Producto> ObtenerProductos()
    {
        return ObtenerTodos(); // usa la misma función de arriba
    }

    // Obtener un producto por ID (útil para buscar por clave)
    public Producto ObtenerPorID(int id)
    {
        Producto producto = null;

        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            var cmd = new MySqlCommand("SELECT * FROM Producto WHERE ID = @id", cn);
            cmd.Parameters.AddWithValue("@id", id);

            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    producto = new Producto
                    {
                        ID = dr.GetInt32("ID"),
                        Nombre = dr.GetString("Nombre"),
                        Precio = dr.GetDecimal("Precio")
                    };
                }
            }
        }

        return producto;
    }
}
