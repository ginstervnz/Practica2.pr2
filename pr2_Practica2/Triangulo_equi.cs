using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_Practica2
{
    internal class Triangulo_equi :triangulo
    {
        private float _lado_equi;
        private float _altura;
        private float _base;



        public Triangulo_equi(float base_triangulo,float lado, float altura, string color) : base(base_triangulo,lado,altura, color) 
        {
            _lado_equi = lado;
            _altura = altura;
            _base = base_triangulo;
        }

        public override double GetArea()
        {
            return (Math.Sqrt(3)/4)*Math.Pow(_lado_equi,2);
        }
        public override double GetPerimetro()
        {
            return 3*_lado_equi;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"El area del triangulo equilatero es: {GetArea()}, su perimetro es {GetPerimetro()}");
        }






    }
}
