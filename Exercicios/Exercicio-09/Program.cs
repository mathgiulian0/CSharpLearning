using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar;

            Console.WriteLine("Digite a quantidade que você possui na carteira: ");
            real = Double.Parse(Console.ReadLine());

            dolar = real / 3.45;

            Console.WriteLine("Você pode comprar " + "$" + dolar + " dólares!");

            Console.ReadLine();
        }
    }
}
