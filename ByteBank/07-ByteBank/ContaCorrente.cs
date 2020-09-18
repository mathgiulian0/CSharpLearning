using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
//using _07_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public static int GetTotalDeContasCriadas()
        {
            return TotalDeContasCriadas;
        }

        private int _agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                    return;
                _agencia = value;
            }
        }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        /* public void SetSaldo(double saldo)
         {
              if (value < 0)
                 {
                     return;
                 }
                 this.saldo = saldo;
         }

         public double GetSaldo()
         {
             return saldo;
         } */

        //nome de função sempre começa com letra maiúscula e o sempre no infinitivo 

       public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        //void = a função não vai ter retorno nenhum 
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}