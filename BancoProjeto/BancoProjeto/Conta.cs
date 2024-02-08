using System;
using System.Drawing;

namespace BancoProjeto
{
    public class Conta
    {
        public Conta()
        { }



        public int Numero { get; set; }
        public double saldo { get; protected set; }

        public Cliente Titular { get; set; }
        public object Saldo { get; internal set; }
        public int Tipo { get; set; }


        public Conta(int numero, double saldo)
        {
            Numero = numero; //não está usando
            this.saldo = saldo;
        }

        public void Deposita(double valor)
        {

            this.Saldo += (valor + 0.10);
        }


        public virtual void Saca(double valor)

        {
            this.Saldo -= valor;
           
        }

    }
}