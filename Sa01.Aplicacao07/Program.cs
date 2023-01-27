using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorT,peca1,peca2,peca3,peca4,peca5;
            Console.WriteLine("Digite o preço da peça 1");
            peca1= decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço da peça 2");
            peca2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço da peça 3");
            peca3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço da peça 4");
            peca4 = decimal.Parse(Console.ReadLine());
            valorT = peca1 + peca2 + peca3 + peca4; 
            Console.WriteLine("O valor total das peças é"+valorT);
            Console.ReadLine();
        }
    }
}
