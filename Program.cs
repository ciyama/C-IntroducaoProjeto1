using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool situacao = false;
            char genero = 'F'; /* para colocar um caracter tem que usar ' aspas simples ' */
            char unicode = '\u0041';
            string nome = "Maria Silva"; /* para colocar uma String "usa-se aspas duplas" */
            byte n1 = 126;
            byte n2 = 254;
            n2++;
            n2++;
            int n3 = 1000;
            int n4 = 2147483647;
            Console.WriteLine(n4);
            n4++;
            float n5 = 4.5f; /* no c# temos que colocar a letra f para indicar o float */
            double n6 = 4.5; /* no c# podemos utilizar o double normalmente, string é uma cadeia de caracteres Unicode IMUTÁVEL(SEGURANÇA, SIMPLICIDADE E THREAD SAFE) */
            double saldo = 12.12234766;


            Console.WriteLine("situação: " + situacao);
            Console.WriteLine("Unicode tabela 0041: " + unicode);
            Console.WriteLine("Byte: "+ n1);
            Console.WriteLine("Byte: "+ n2); /* Cuidado que quando o tipo byte tem que olhar na tabela o valor que ele compreende, 
            ele vai de 0 a 255 por isso dependendo do numero e do valor que vc definir ele vai voltar para o inicio, 
            se ele compreende numero negativo entao ele volta para o numero que seja o inicio */
            Console.WriteLine("Int: "+ n3);
            Console.WriteLine("Int: "+ n4);
            Console.WriteLine("Float: "+ n5);
            Console.WriteLine("Double: "+ n6);
            Console.WriteLine("String nome: " + nome);            
            Console.WriteLine("Saldo: " + (saldo.ToString("F2")));
            Console.WriteLine("Saldo: " + (saldo.ToString("F4")));
            Console.WriteLine("Saldo: " + (saldo.ToString("F4", CultureInfo.InvariantCulture)));
        }
    }
}
