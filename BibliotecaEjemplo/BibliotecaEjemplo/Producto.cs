﻿namespace BibliotecaEjemplo
{
    public class Producto
    {
        // Campos privados 

        private string nombre;

        private decimal precio;



        // Propiedades públicas 

        public string Nombre

        {

            get { return nombre; }

            set { nombre = value; }

        }



        public decimal Precio

        {

            get { return precio; }

            set { precio = value; }

        }



        // Método que retorna descripción 

        public string ObtenerDescripcion()

        {

            return $"Producto: {Nombre}, Precio: {Precio:C}";

        }
    }
}
