using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class ClienteController
{
    private ApplicationDbContext context;

    public ClienteController(ApplicationDbContext context)
    {
        this.context = context;
    }

    // Obtener todos los clientes
    public List<Cliente> ObtenerTodos()
    {
        var lista = new List<Cliente>();
        using (var cn = Conexion.ObtenerConexion())  // Uso de la clase Conexion
        {
            cn.Open();
            var cmd = new MySqlCommand("SELECT * FROM Cliente", cn);
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lista.Add(new Cliente
                    {
                        ID = dr.GetInt32("ID"),
                        Nombre = dr.GetString("Nombre"),
                        Direccion = dr.GetString("Direccion")
                    });
                }
            }
        }
        return lista;
    }

    // Crear un nuevo cliente
    public void Crear(Cliente c)
    {
        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            var cmd = new MySqlCommand("INSERT INTO Cliente (Nombre, Direccion) VALUES (@n, @d)", cn);
            cmd.Parameters.AddWithValue("@n", c.Nombre);
            cmd.Parameters.AddWithValue("@d", c.Direccion);
            cmd.ExecuteNonQuery();
        }
    }

    // Actualizar cliente
    public void Actualizar(Cliente c)
    {
        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            var cmd = new MySqlCommand("UPDATE Cliente SET Nombre=@n, Direccion=@d WHERE ID=@id", cn);
            cmd.Parameters.AddWithValue("@n", c.Nombre);
            cmd.Parameters.AddWithValue("@d", c.Direccion);
            cmd.Parameters.AddWithValue("@id", c.ID);
            cmd.ExecuteNonQuery();
        }
    }

    // Eliminar un cliente
    public void Eliminar(int id)
    {
        using (var cn = Conexion.ObtenerConexion())
        {
            cn.Open();
            var cmd = new MySqlCommand("DELETE FROM Cliente WHERE ID=@id", cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
