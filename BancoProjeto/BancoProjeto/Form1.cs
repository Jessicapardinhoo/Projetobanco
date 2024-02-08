using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoProjeto
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c = new Conta();
            Conta c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("victor");
            c.Titular = cliente;
            textoTitular.Text = c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
            //
            ContaPoupanca C = new ContaPoupanca();
            c.Deposita(100.0);
            c.Saca(50);
        }



        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");


        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");

        }
    }
}



 
   

