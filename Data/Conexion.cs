using MySql.Data.MySqlClient;

public class Conexion
{
    // Cadena de conexión a la base de datos MariaDB
    private static string connectionString = "Server=127.0.0.1;Database=tienda_pedidos;Uid=root;Pwd=;";

    // Obtener la conexión MySql
    public static MySqlConnection ObtenerConexion()
    {
        return new MySqlConnection(connectionString);
    }
}
