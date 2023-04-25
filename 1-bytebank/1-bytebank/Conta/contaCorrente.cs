using _1_bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_bytebank.Conta
{
    public class contaCorrente
    {
        // static: propriedade da classe e não dos objetos
        public static int TotalDeContasCriadas { get; private set; }

        private int numeroAgencia;

        // encapsulando campos
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set { 
                    if(value > 0)
                    {
                        this.numeroAgencia = value;
                    }
                }
        }
        
        // propriedade autoimplementada
        public string Conta { get; set; }

        private double saldo;

        public Cliente Titular { get; set; }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public bool sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool transferir(double valor, contaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                sacar(valor);
                destino.depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = this.saldo + valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public contaCorrente(int NumeroAgencia, string NumeroConta)
        {
            this.NumeroAgencia = NumeroAgencia;
            this.Conta = NumeroConta;
            TotalDeContasCriadas++;
        }

    }
}
