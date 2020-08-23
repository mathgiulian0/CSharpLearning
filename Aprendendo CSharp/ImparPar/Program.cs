using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Impar ou Par");

            //Instanciação da variável inicializadora
            int numero = 0;

            //Enquanto o número for menor que 100
            while (numero <= 100)
            {
                //Se o mod do número for igual a zero, é par
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número " + numero + " é par");
                    numero++;
                }
                //Se o mod for diferente de zero, é ímpar
                else
                {
                    Console.WriteLine("O número " + numero + " é impar");
                    numero++;
                }
            }

            Console.ReadLine();
        }
    }
}
