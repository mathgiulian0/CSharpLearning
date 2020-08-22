using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2.0");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            //bool = boolean
            bool acompanhado = quantidadePessoas >= 2;

            /* || = OR 
               && = AND */
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode subir arrombado.");
            }
            else
            {
                Console.WriteLine("Não vai subir ninguém.");
            }


            Console.ReadLine();
        }
    }
}
