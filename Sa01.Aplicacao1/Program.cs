using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor1, valor2, soma;
            Console.WriteLine("Qual valor do primeiro avião");
            valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Qual valor do segundo avião");
            valor2 = decimal.Parse(Console.ReadLine());
            soma = valor1 + valor2;
            Console.WriteLine("Valor da soma dos dois aviões são..." + soma);
            Console.ReadLine();
        }
    }
}
