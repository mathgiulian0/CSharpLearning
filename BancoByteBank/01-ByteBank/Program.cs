using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.titular = "Gabriela";
            contaCorrente.agencia = 863;
            contaCorrente.numero = 863146;
            contaCorrente.saldo = 100;


            Console.WriteLine("Titular: " + contaCorrente.titular);
            Console.WriteLine("Agência: " + contaCorrente.agencia);
            Console.WriteLine("Número: " + contaCorrente.numero);
            Console.WriteLine("Saldo: " + contaCorrente.saldo);

            contaCorrente.saldo += 200;

            Console.WriteLine("Saldo: " + contaCorrente.saldo);

            

            Console.ReadLine();
        }
    }
}
