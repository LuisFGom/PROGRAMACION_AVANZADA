using System.Collections.Generic;

namespace CapaDeAccesoADatos
{
    public class AccesoProducto
    {
        // Lista de productos (vacía al principio)
        private static List<string> productos = new List<string>();

        // Obtener todos los productos
        public List<string> ObtenerTodosLosProductos()
        {
            return productos;
        }

        // Agregar un producto
        public void AgregarProducto(string producto)
        {
            productos.Add(producto);  // Agregar el producto a la lista
        }
    }
}
