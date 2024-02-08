using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoProjeto
{
    internal class ContaPoupanca : Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
   
}
