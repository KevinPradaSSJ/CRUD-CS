using System;

namespace TiendaCS
{
    class PruebaConexion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRUEBA DE CONEXIÓN A MYSQL ===\n");
            
            try
            {
                Console.WriteLine("Intentando conectar a MySQL...");
                
                // Intentar obtener la conexión
                var connection = DatabaseConnection.GetConnection();
                
                Console.WriteLine("✅ ¡CONEXIÓN EXITOSA!");
                Console.WriteLine($"Estado de la conexión: {DatabaseConnection.IsConnectionActive()}");
                Console.WriteLine($"Servidor: localhost");
                Console.WriteLine($"Base de datos: tienda_cs");
                Console.WriteLine($"Usuario: root");
                
                // Probar una consulta simple
                Console.WriteLine("\nProbando consulta simple...");
                var result = DatabaseConnection.ExecuteQuery("SELECT 1 as test");
                Console.WriteLine("✅ Consulta ejecutada correctamente");
                
                // Cerrar conexión
                DatabaseConnection.CloseConnection();
                Console.WriteLine("✅ Conexión cerrada correctamente");
                
                Console.WriteLine("\n🎉 ¡TODAS LAS PRUEBAS PASARON EXITOSAMENTE!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ ERROR EN LA CONEXIÓN:");
                Console.WriteLine($"Mensaje: {ex.Message}");
                Console.WriteLine($"Tipo: {ex.GetType().Name}");
                
                Console.WriteLine("\n🔧 POSIBLES SOLUCIONES:");
                Console.WriteLine("1. Verifica que Laragon esté ejecutándose");
                Console.WriteLine("2. Confirma que MySQL esté iniciado en Laragon");
                Console.WriteLine("3. Asegúrate de que la base de datos 'tienda_cs' exista");
                Console.WriteLine("4. Verifica que el usuario 'root' no tenga contraseña");
            }
            
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
