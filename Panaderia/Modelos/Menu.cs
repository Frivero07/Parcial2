using Panaderia.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.Modelos
{
    static public class Menu
    {
        public static void AgregarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la categoria: ");
            foreach (var categoria in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine($"{(int)categoria}. {categoria}");
            }
            int seleccion = int.Parse(Console.ReadLine());
            Categoria destinoSeleccion = (Categoria)seleccion;
            Producto producto = new Producto(nombre, precio, destinoSeleccion);
            Inventario.AgregarProducto(producto);
        }

        public static void EliminarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Inventario.EliminarProducto(nombre);
        }

        public static void ActualizarDetalles()
        {
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese el nuevo precio: ");
            double nuevoPrecio = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la nueva  categoria: ");
            foreach (var categoria in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine($"{(int)categoria}. {categoria}");
            }
            int seleccion = int.Parse(Console.ReadLine());
            Categoria nuevaCategoria = (Categoria)seleccion;
            Inventario.ActualizarDetalles(nombre, nuevoPrecio, nuevaCategoria);
        }

        public static void MostrarInventario() => Inventario.MostrarInventario();
        public static void CalcularTotal() {
            Console.WriteLine($"Total:{Inventario.CalcularTotal()}");
            
        }
    }
}
