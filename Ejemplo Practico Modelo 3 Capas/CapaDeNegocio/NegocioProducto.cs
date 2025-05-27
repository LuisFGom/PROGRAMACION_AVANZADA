using CapaDeAccesoADatos;
using System.Collections.Generic;

namespace CapaDeNegocio
{
    public class NegocioProducto
    {
        private AccesoProducto _accesoProducto;

        public NegocioProducto()
        {
            _accesoProducto = new AccesoProducto();  // Creamos una instancia de la clase de acceso a datos
        }

        // Método para obtener todos los productos
        public List<string> ObtenerProductos()
        {
            return _accesoProducto.ObtenerTodosLosProductos();  // Llamamos a la capa de acceso a datos
        }

        // Método para agregar un producto
        public void AgregarProducto(string producto)
        {
            if (string.IsNullOrEmpty(producto))
            {
                throw new System.ArgumentException("El producto no puede estar vacío.");
            }

            _accesoProducto.AgregarProducto(producto);  // Llamamos a la capa de acceso a datos
        }
    }
}
