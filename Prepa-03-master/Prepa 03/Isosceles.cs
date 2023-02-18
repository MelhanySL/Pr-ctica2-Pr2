using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Isosceles : Triangulo
    {
        public Isosceles(float base_triangulo, float lado, string color) : base(base_triangulo, lado, lado, color)
        {
            
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Isosceles de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }
}
