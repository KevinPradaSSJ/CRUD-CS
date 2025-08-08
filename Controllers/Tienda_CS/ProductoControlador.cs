using Models.Tienda_CS;
using System;
using System.Collections.Generic;
using System.Data;
using Tienda_CS;


namespace Controllers.Tienda_CS
{
    public class ProductoControlador
    {
        //CLASE PARA EL CONTROLADOR DE PRODUCTO

        public bool EliminarProducto(int id)
        {
            // Lógica para eliminar un producto por su ID
            string query = $"DELETE FROM productos WHERE id_producto = {id}";
            int result = DatabaseConnection.ExecuteNonQuery(query);
            return result > 0; // Retorna true si se eliminó al menos un producto
        }
    }
}
