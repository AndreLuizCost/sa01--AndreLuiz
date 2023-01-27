using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeAviao, multiplicacao;
            Console.WriteLine("Qual a quantidade de avião");
            quantidadeAviao= int.Parse(Console.ReadLine());
            multiplicacao = quantidadeAviao * 17;
            Console.WriteLine("A quantidade de poltronas é "+ multiplicacao);
            Console.ReadLine ();    
        }
    }
}
