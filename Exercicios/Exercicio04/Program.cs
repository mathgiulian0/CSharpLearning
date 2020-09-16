using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.Write("Digite um valor: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma entre " + x + " e " + y + " é igual a " + (x+y) + ".");

            Console.ReadLine();
        }
    }
}
