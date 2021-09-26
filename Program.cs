using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int resultado1 = 3 + 4 * 2;
            int resultado2 = (3 + 4) * 2;
            int resultado3 = 17 % 3;
            double resultado4 = 10 / 8 ;
            double resultado5 = (double) 10 / 8;
            double resultado6 = 10.0 / 8;
            double resultado7 = 10.0 / 8.0;

            // Bascara x = (-b +- raiz quadrada de b ao quadrado - 4 a. c ) / 2.a
            double a = 1.0, b = -3.0, c = -4.0;

            // double delta = b * b - 4 * a * c;
            double delta = Math.Pow(b, 2) - 4 * a * c;

            double bhaskara1 = (-b + Math.Sqrt(delta)) / (2 * a) ;
            double bhaskara2 = (-b - Math.Sqrt(delta)) / (2 * a) ;







            System.Console.WriteLine("Resultado 1: " + resultado1);
            System.Console.WriteLine("Resultado 2: " + resultado2);
            System.Console.WriteLine("Resultado 3: " + resultado3);
            System.Console.WriteLine("Resultado 4: " + resultado4);
            System.Console.WriteLine("Resultado 5: " + resultado5);
            System.Console.WriteLine("Resultado 6: " + resultado6);
            System.Console.WriteLine("Resultado 7: " + resultado7);
            System.Console.WriteLine("Resultado delta: " + delta);
            System.Console.WriteLine("Resultado bhaskara1= " + bhaskara1);
            System.Console.WriteLine("Resultado bhaskara2= " + bhaskara2);
        }
    }
}
