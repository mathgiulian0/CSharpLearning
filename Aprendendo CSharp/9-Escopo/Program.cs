using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;

            //bool = boolean
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado.";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado.";
            }

            /* || = OR 
               && = AND */
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode subir arrombado.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não vai subir ninguém.");
            }


            Console.ReadLine();
        }
    }
}
