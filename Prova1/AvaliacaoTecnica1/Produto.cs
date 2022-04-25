using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoTecnica1
{
   public  class Produto
    {
        public string NomeProduto { get; set; }

        public Produto()
        {
        }

        public Produto(string nomeProduto)
        {
            NomeProduto = nomeProduto;
        }

       

    }
}
