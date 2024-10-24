using Panaderia.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.Modelos
{
    static public class Inventario
    {
        static List<Producto> listainventario = new();
        static string ArchivoProductos = "Productos.txt";


        public static void AgregarProducto(Producto producto)
        {
            listainventario.Add(producto);
            GuardarDato(producto);
            
        }
        public static void EliminarProducto(string nombre)
        {
            var producto = listainventario.Find(j => j.Nombre == nombre);
            if (producto != null)
            {
                listainventario.Remove(producto);
                GuardarDatos();
                Console.WriteLine("El producto se ha eliminado");
            }
            else
            {
                Console.WriteLine("El producto no se encontro");
            }
        }

        public static void ActualizarDetalles(string nombre, double nuevoPrecio, Categoria nuevaCategoria)
        {
            var producto = listainventario.Find(j => j.Nombre == nombre);
            if (producto != null)
            {
                producto.Precio = nuevoPrecio;
                producto.Categoria = nuevaCategoria;
                GuardarDatos();

                Console.WriteLine("El producto se modifico correctamente");
                
            }
            else
            {
                Console.WriteLine("El producto no se encontro");
            }
        }

        public static void MostrarInventario()
        {
            if (listainventario.Count > 0)
            {
                foreach (var producto in listainventario)
                {
                    Console.WriteLine(producto);

                }
            }
            else
            {
                Console.WriteLine("No hay productos para mostrar");
            }
        }

        public static double CalcularTotal()
        {

            double total = 0;
            
            foreach (var producto in listainventario)
            {
                total += producto.Precio;
            }
            return total;
        }

        public static void CargarDatos()
        {
            if (File.Exists(ArchivoProductos))
            {
                var lineas = File.ReadAllLines(ArchivoProductos);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(", ");
                    string nombre = datos[0];
                    double precio = double.Parse(datos[1]);
                    // parsear un string a tipo Enum.
                    Categoria categoria = (Categoria)Enum.Parse(typeof(Categoria), datos[2]);
                    Producto producto = new(nombre, precio, categoria);
                    listainventario.Add(producto);
                }
            }
        }
        public static void GuardarDato(Producto producto)
        {
            using StreamWriter writer = new StreamWriter(ArchivoProductos, true);
            writer.WriteLine(producto);
        }
        public static void GuardarDatos()
        {
            using StreamWriter writer = new StreamWriter(ArchivoProductos);
            foreach (var producto in listainventario)
            {
                writer.WriteLine(producto);
            }
        }
    }
}
    
