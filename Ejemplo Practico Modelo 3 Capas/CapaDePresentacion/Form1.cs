using System;
using System.Windows.Forms;
using CapaDeNegocio;

namespace CapaDePresentacion
{
    public partial class Form1 : Form
    {
        private NegocioProducto negocioProducto;

        public Form1()
        {
            InitializeComponent();  // Inicializa los componentes de Windows Forms
            negocioProducto = new NegocioProducto();  // Instanciamos la Capa de Negocio
            CargarProductos();  // Cargamos los productos (vacío al principio)
        }

        // Método para cargar los productos en el ListBox
        private void CargarProductos()
        {
            lstProducts.Items.Clear();  // Limpiar el ListBox
            var productos = negocioProducto.ObtenerProductos();  // Obtener productos de la Capa de Negocio
            foreach (var producto in productos)
            {
                lstProducts.Items.Add(producto);  // Añadir el nombre del producto al ListBox
            }
        }

        // Evento que se ejecuta cuando se hace clic en el botón "Agregar Producto"
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string nuevoProducto = txtNewProduct.Text;  // Obtener nombre del TextBox

            try
            {
                if (!string.IsNullOrEmpty(nuevoProducto))  // Verificar que el nombre no esté vacío
                {
                    negocioProducto.AgregarProducto(nuevoProducto);  // Agregar el producto
                    CargarProductos();  // Recargar la lista con el nuevo producto
                    txtNewProduct.Clear();  // Limpiar el campo de texto
                }
                else
                {
                    MessageBox.Show("El nombre del producto no puede estar vacío.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // Si hay un error, mostramos el mensaje de excepción
            }
        }
    }
}
