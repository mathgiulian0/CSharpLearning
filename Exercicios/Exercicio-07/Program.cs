using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine("O dobro de " + numero + " é " + (numero * 2));
            Console.WriteLine("A terça parte de " + numero + " é " + (numero / 3));

            Console.ReadLine();
        }
    }
}
