using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 42;
            double saldo = 10.35784;
            string nome = "Carlos";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2} reais", nome, idade, saldo); /* Placeholder formatado com tipos double com 2 casas decimais */           
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R${saldo:F2} reais"); /* interpolação formatado com tipos double com 2 casas decimais */           
            System.Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$" + saldo.ToString("F2") + " reais");
        }
    }
}
