using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2}");
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + (medida.ToString("F3", CultureInfo.InvariantCulture)));
            
            
        }
    }
}
