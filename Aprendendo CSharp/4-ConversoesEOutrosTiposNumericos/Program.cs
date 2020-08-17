using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            /*o int suporta até valores de 32 bits*/
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; /*transformando o double em int*/
            Console.WriteLine(salarioEmInteiro);

            /*long é um número inteiro que suporta números grandes, até 64 bits*/
            long idade = 13000000000;
            Console.WriteLine(idade);

            /*short aceita valores menores que o int, até 16 bits*/
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            /*o 'f' depois da atribuição do valor é para dizer que se trata de um float e não um double*/
            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.ReadLine();
        }
    }
}
