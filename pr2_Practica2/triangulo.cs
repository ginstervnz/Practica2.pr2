using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_Practica2
{
    internal class triangulo : Figura
    {
        private float _lado;
        private float _altura;
        private float _base;



        public triangulo(float base_general, float lado, float altura, string color) : base(color)
        {
          _lado= lado;
          _altura = altura;
            _base = base_general;
                
        }
        public triangulo(float base_general,float lado, string color) : base(color)
        {
            _base= base_general;
            _lado= lado;
        }

        public override double GetArea()
        {
            return (_lado * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _lado + _lado + _lado;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"El area del triangulo es: {GetArea()}, su perimetro es {GetPerimetro()}");
        }


    }
}
