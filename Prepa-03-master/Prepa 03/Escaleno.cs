using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Escaleno : Triangulo
    {
        public Escaleno(float base_triangulo, float lado1, float lado2, string color) : base(base_triangulo, lado1, lado2, color)
        {
           
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }
}
