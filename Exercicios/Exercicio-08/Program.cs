using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, Km, Hm, Dam, dm, cm, mm;

            Console.Write("Digite uma distância em metros: ");
            m = Double.Parse(Console.ReadLine());

            Km = m / 1000;
            Hm = m / 100;
            Dam = m / 10;
            dm = m * 10;
            cm = m * 100;
            mm = m * 1000;

            Console.WriteLine("A distância de " + m + "m " + "corresponde a: ");
            Console.WriteLine(Km + " Km");
            Console.WriteLine(Hm + " Hm");
            Console.WriteLine(Dam + " Dam");
            Console.WriteLine(dm + " dm");
            Console.WriteLine(cm + " cm");
            Console.WriteLine(mm + " mm");

            Console.ReadLine();
        }
    }
}
