using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double media;

            Console.Write("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("A média entre " + nota1 + " e " + nota2 + " é igual a " + media + ".");

            Console.ReadLine();
        }
    }
}
