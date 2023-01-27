using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal aviao1, aviao2, aviao3, aviao4;
            decimal sub1, sub2, sub3, sub4, totalGeral;
            int qtde;
           
            Console.WriteLine("quantos aviões você deseja ");
            qtde = int.Parse(Console.ReadLine());
            
             Console.WriteLine("Qual valor do aviao1");
                aviao1=decimal.Parse(Console.ReadLine());
            sub1 = aviao1 * qtde;
            Console.WriteLine("Qual valor do aviao2");
            aviao2 = decimal.Parse(Console.ReadLine());
            sub2= aviao2 * qtde;

            Console.WriteLine("Qual valor do aviao3");
            aviao3 = decimal.Parse(Console.ReadLine());
            sub3= aviao3 * qtde;    

            Console.WriteLine("Qual valor do aviao4");
            aviao4 = decimal.Parse(Console.ReadLine());
            sub4 = aviao4 * qtde;
            totalGeral = sub1+sub2+sub3 +sub4;
            Console.Clear();
            Console.WriteLine("O valor total da frota é" + totalGeral);
            Console.ReadLine();

        }
    }
}
