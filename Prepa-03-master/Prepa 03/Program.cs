using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura3 = new Circulo(2, "negro");

            figura1.MostrarDatos();
          
            figura2.MostrarDatos();
           
            figura3.MostrarDatos();

            Triangulo triangulo_equilatero = new Equilatero(5, "rosa");
            Figura figura4 = triangulo_equilatero;

            figura4.MostrarDatos();

            Triangulo triangulo_isosceles = new Isosceles(8, 7, "amarillo");
            Figura figura5 = triangulo_isosceles;
            figura5.MostrarDatos();

            Triangulo triangulo_escaleno = new Escaleno(7, 6, 2, "verde");
            Figura figura6 = triangulo_escaleno;

            figura6.MostrarDatos();

            //Triangulo triangulo = new Triangulo(3, 5, 5, "lila");
            //triangulo.MostrarDatos();

            //Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            Console.ReadLine();
           
            
        }
    }
}
