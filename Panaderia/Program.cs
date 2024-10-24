using Panaderia.Modelos;

namespace Panaderia
{
    public class Program
    {
        static void Main()
        {
            int opcion;
            
            Inventario.CargarDatos();

            do
            {
                Console.WriteLine("\n");

                Console.WriteLine("1. Agregar Producto.");
                Console.WriteLine("2. Eliminar Producto.");
                Console.WriteLine("3. Actualizar Detalles.");
                Console.WriteLine("4. Mostrar inventario.");
                Console.WriteLine("5. Calcular Total.");
                Console.WriteLine("6. Guardar y Salir.");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n");
                        Menu.AgregarProducto();
                        break;

                    case 2:
                        Console.WriteLine("\n");
                        Menu.EliminarProducto();
                        break;

                    case 3:
                        Console.WriteLine("\n");
                        Menu.ActualizarDetalles();
                        break;

                    case 4:
                        Console.WriteLine("\n");
                        Menu.MostrarInventario();
                        break;
                    case 5:
                        Console.WriteLine("\n");
                        Menu.CalcularTotal();
                        break;
                }
            } while (opcion != 6);

            // Guarda los datos de libros y usuarios antes de salir del programa
            Inventario.GuardarDatos();
        }
    }
}
        
    

