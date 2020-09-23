using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titular = "Gabriela";
            contaCorrente.agencia = 863;
            contaCorrente.numero = 863452;


            ContaCorrente contaCorrente2 = new ContaCorrente();
            contaCorrente.titular = "Gabriela";
            contaCorrente.agencia = 863;
            contaCorrente.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaCorrente == contaCorrente2));

            contaCorrente = contaCorrente2;
            Console.WriteLine(contaCorrente == contaCorrente2);

            contaCorrente.saldo = 300;
            Console.WriteLine(contaCorrente.saldo);
            Console.WriteLine(contaCorrente2.saldo);

            if(contaCorrente.saldo >= 100)
            {
                contaCorrente.saldo -= 100;
            }


            Console.ReadLine();
        }
    }
}

