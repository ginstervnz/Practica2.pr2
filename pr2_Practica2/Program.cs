using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pr2_Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2, 3, "blanco");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura3 = new Circulo(2, "negro");

            figura1.MostrarDatos();

            figura2.MostrarDatos();

            figura3.MostrarDatos();

            Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            Console.ReadLine();

            //deberia funcionar todo


            Triangulo_equi figura4= new Triangulo_equi(2,4,7,"Verde");
            Triangulo_escaleno figura5 = new Triangulo_escaleno(6, 4, 10, "Rojo");
            Triangulo_iso figura6 = new Triangulo_iso(7, 10, 20, "Blanco");

            figura4.MostrarDatos();
            figura5.MostrarDatos(); 
            figura6.MostrarDatos(); 
            





        }
    }
}
