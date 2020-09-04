using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome + ", é um prazer te conhecer!");

            Console.ReadLine();
        }
    }
}
