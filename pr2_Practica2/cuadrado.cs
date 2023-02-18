using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_Practica2
{
    class Cuadrado : Rectangulo
    {
        public Cuadrado(float lado, string color) : base(lado, lado, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Cuadrado de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }
}
