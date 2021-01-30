using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___10
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, altura, m2, tinta;

            Console.WriteLine("Largura: ");
            largura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Altura: ");
            altura = Double.Parse(Console.ReadLine());

            m2 = altura * largura;

            Console.WriteLine("Sua parede tem a dimensão de " + largura + "x" + altura + " e a sua área é de " + m2 + "m²");

            tinta = m2 / 2;

            Console.WriteLine("Você poderá pintar " + tinta + " metros quadrados!");

            Console.ReadLine();
        }
    }
}
