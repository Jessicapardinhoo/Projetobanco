using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace BancoProjeto
{
    internal class Cliente
    {
        private string v;
       

        public Cliente(string v)
        {
            this.Nome = v;
          
        }

        public string Nome { get; set; }


   
        }
    }

