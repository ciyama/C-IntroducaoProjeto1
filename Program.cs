using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float a;
            double b;
           
            a = 5.1f;
            b = a;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

            double c;
            float d;

            c = 5.1;
            d = (float)c;  /* Casting para tranformação forçada de um Double para um Float de 8 byte para 4 byte.*/

            System.Console.WriteLine(c);
            System.Console.WriteLine(d);

            int f;
            f = (int)c;

            System.Console.WriteLine(f);

            int g;
            int h;

            g = 5;
            h = 2;
            double resultado = (double) g / h; /* Cuidado com o resultado pois quando estamos dividindo 2 numeros inteiros o resultado é inteiro, então devemos fazer um casting para o resultado ficar correto */

            System.Console.WriteLine(resultado);     





            
        }
    }
}
