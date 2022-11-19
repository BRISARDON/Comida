using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_2
{
    class Menu 
    {
        private string nombre;
        private float precio;

        public string Nombre { get; set; }
        public float Precio { get;set; }

        

        public void HamburguesaSimple(float h)
        {
            
            nombre = "Hamburguesa";
            precio = 500;
            
            float valor = h * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(h + "            " + nombre);
            archivo.Close();
            
            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor);
            archivoPrecios.Close();


        }

        public void HamburguesaQueso(float h)
        {
            
            nombre = "Hamburguesa c/ Queso";
            precio = 650;

            float valor = h * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(h + "            " + nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor);
            archivoPrecios.Close();
        }

        public void DobleCarne(float h)
        {

            nombre = "Doble Carne Doble Queso";
            precio = 800;

            float valor = h * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(h + "            " + nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor);
            archivoPrecios.Close();
        }

        public void PapasFritasSimple(float p)
        {
            nombre = "Papas Fritas";
            precio = 300;

            float valor = p * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(p + "            " + nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor);
            archivoPrecios.Close();
        }

        public void PapasCheddar(float p)
        {
            nombre = "Papas Cheddar";
            precio = 450;

            float valor1 = p * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(p + "            " + nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor1);
            archivoPrecios.Close();
        }

        public void CocaCola(float b)
        {
            nombre = "Coca Cola";
            precio = 250;

            float valor = b * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(b + "            " + nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor);
            archivoPrecios.Close();
        }

        public void Fanta(float b)
        {
            nombre = "Fanta";
            precio = 250;

            float valor = b * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(b + "            " + nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor);
            archivoPrecios.Close();
        }

        public void Sprite(float b)
        {
            nombre = "Sprite";
            precio = 250;

            float valor = b * precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(b + "            " + nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor);
            archivoPrecios.Close();
        }


    }
}
