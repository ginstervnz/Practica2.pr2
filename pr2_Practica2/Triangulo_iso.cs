using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_Practica2
{
    internal class Triangulo_iso : triangulo
    {
        private float _ladoigual;
        private float _base;
        private float _altura_iso;

        public Triangulo_iso(float base_triangulo, float lado, float altura, string color) : base( base_triangulo,lado,altura,color)
        {
            _ladoigual= lado;
            _altura_iso= altura;
            _base= base_triangulo;
        }

        public override double GetArea()
        {
            return (_base * _altura_iso) / 2;
        }
        public override double GetPerimetro()
        {
            return 2 * (_ladoigual + _base);
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"El area del triangulo isoseles es: {GetArea()}, su perimetro es {GetPerimetro()}");
        }





    }
}
