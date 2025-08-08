using System;
using System.Data;
using Models.Tienda_CS;

namespace Controllers.Tienda_CS
{
    internal class ProductoControlador
    {
        
        public bool CrearProducto(Producto producto)
        {
            try
            {
                string query = @"INSERT INTO productos (nombre, precio, tipo_id, stock) 
                               VALUES (@nombre, @precio, @tipo_id, @stock)";

                using (var connection = DatabaseConnection.GetConnection())
                {
                    using (var command = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", producto.Nombre);
                        command.Parameters.AddWithValue("@precio", producto.Precio);
                        command.Parameters.AddWithValue("@tipo_id", producto.TipoId);
                        command.Parameters.AddWithValue("@stock", producto.Stock);

                        int filasAfectadas = command.ExecuteNonQuery();
                        
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine(" Producto creado exitosamente");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine(" No se pudo crear el producto");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error al crear el producto: {ex.Message}");
                return false;
            }
        }

        public bool ActualizarProducto(Producto producto)
        {
            try
            {
                string updateQuery = @"UPDATE productos 
                                     SET nombre = @nombre, precio = @precio, 
                                         tipo_id = @tipo_id, stock = @stock 
                                     WHERE id_producto = @id_producto";

                using (var connection = DatabaseConnection.GetConnection())
                {
                    using (var command = new MySql.Data.MySqlClient.MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", producto.Nombre);
                        command.Parameters.AddWithValue("@precio", producto.Precio);
                        command.Parameters.AddWithValue("@tipo_id", producto.TipoId);
                        command.Parameters.AddWithValue("@stock", producto.Stock);
                        command.Parameters.AddWithValue("@id_producto", producto.IdProducto);

                        int filasAfectadas = command.ExecuteNonQuery();
                        
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine(" Producto actualizado exitosamente");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine(" No se pudo actualizar el producto");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error al actualizar el producto: {ex.Message}");
                return false;
            }
        }
    }
}
