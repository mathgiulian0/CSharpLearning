﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("O antecessor de " + numero + " é " + (numero - 1));
            Console.WriteLine("O sucessor de " + numero + " é " + (numero + 1));

            Console.ReadLine();
        }
    }
}
