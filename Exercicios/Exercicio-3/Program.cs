using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            double salario;

            Console.WriteLine("Nome do Funcionário: ");
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("O funcionário " + nomeFuncionario + " tem um salário de " + salario + " em Junho.");

            Console.ReadLine();
        }
    }
}
