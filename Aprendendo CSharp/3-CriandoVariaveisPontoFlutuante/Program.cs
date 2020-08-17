using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis ponto flutuante");

            double salario = 1200.70;

            Console.WriteLine(salario);

            double idade = 15;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            /*vai exibir um resultado do tipo int pois o valor informado está como int*/
            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            /*vai exibir um resultado do tipo double pois o valor informado está como double*/
            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("Aperte enter para fechar...");
            Console.ReadLine();
        }
    }
}
