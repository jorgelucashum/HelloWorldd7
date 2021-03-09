using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldd7
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo(); // 'new Triangulo()' serve para instanciar a classe na variavel, apontando pro endereço de memoria.
            y = new Triangulo();

            Console.WriteLine("Digite as 3 medidas do triângulo para X: ");
            x.A = double.Parse(Console.ReadLine()); // 'x.A' serve para fazer referencia ao valor 'A' na classe 'Triangulo' 
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as 3 medidas do triângulo para Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) /2;
            double areaX = Math.Sqrt( p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área do X: " + areaX.ToString("F4"));
            Console.WriteLine("Área do Y: " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("A area do X é maior");
            }
            else
            {
                Console.WriteLine("Area do Y é maior");
            }

            Console.ReadLine();
        }

    }
}
