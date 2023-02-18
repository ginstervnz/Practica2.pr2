using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_Practica2
{
    internal class Triangulo_escaleno : triangulo               //en este caso use la altura como uno de los lados del triangulo ya que facilita_
                                                                // el ejercicio, sin embargo no es la mejor respuesta ya que existe una formula_
                                                                // que da un resultado mas flexibe y exacto
    {
        private float _lado_a;
        private float _lado_b;
        private float _lado_c;
        public Triangulo_escaleno(float base_general, float lado,float altura, string color) : base (base_general,lado,altura,color)
        {
            _lado_a = base_general;
            _lado_b = lado;
            _lado_c = altura;

        }
        public override double GetArea()
        {
            return (_lado_a * _lado_c) / 2;
        }
        public override double GetPerimetro()
        {
            return _lado_a + _lado_b + _lado_c;
        }

        
        public override void MostrarDatos()
        {
            Console.WriteLine($"El area del triangulo escaleno es: {GetArea()}, y su perimetro es {GetPerimetro()}");
        }

    }
}
