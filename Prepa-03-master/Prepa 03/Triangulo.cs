using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo: Figura
    {
        private float _base;
        private float _lado1;
        private float _lado2;
        private double _altura;

        public Triangulo(float base_triangulo, float lado1, float lado2, string color) : base(color)
        {
            _base = base_triangulo;
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public override double GetArea()
        {
            if (_base == _lado1 && _base == _lado2)
            {
                _altura = (Math.Sqrt(3) / 2) * _base;
            }
            else if (_lado1 == _lado2)
            {
                _altura = Math.Sqrt(Math.Pow(_lado1, 2) - (Math.Pow(_base, 2) / 4));
            }
            else
            {
                //Ley o Formula de Heron
                double _semiperimetro;
                _semiperimetro = (_base + _lado1 + _lado2) / 2;
                _altura = (2 / _base) * (Math.Sqrt(_semiperimetro * (_semiperimetro - _base) * (_semiperimetro - _lado1) * (_semiperimetro - _lado2)));
            }
            return (_base * _altura)/2;
        }
        public override double GetPerimetro()
        {
            return _base + _lado1 + _lado2;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triángulo de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
