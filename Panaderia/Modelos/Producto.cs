using Panaderia.Enums;


namespace Panaderia.Modelos
{
    public class Producto
    {

        public string Nombre { get; set; }
        public double Precio {  get; set; }
        public Categoria Categoria { get; set; }
        public Producto(string nombre, double precio, Categoria categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Precio}, {Categoria}";
        }
    }
}
