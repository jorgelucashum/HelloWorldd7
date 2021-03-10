using System;
//Orientação a objeto, criando classes.

// Classe é a definição do tipo. Ex: 'class Triangulo'
// Objetos são instâncias da classe. Ex:  'x = A, B, C' e 'y = A, B, C'

namespace HelloWorldd7
{
    class Triangulo
    {
        public double A, B, C;


        public double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

