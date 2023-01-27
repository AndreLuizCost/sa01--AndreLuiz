using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal janeiro, fevereiro, marco, media;
            Console.WriteLine("Digite o faturamento de janeiro");
            janeiro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o faturamento de fevereiro");
            fevereiro= decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o faturamento de marco");
                marco= decimal.Parse(Console.ReadLine());
            media = (janeiro + fevereiro + marco) / 3; 
            Console.WriteLine("A média trimestral é..."+ media);
            Console.ReadLine ();

        }
    }
}
