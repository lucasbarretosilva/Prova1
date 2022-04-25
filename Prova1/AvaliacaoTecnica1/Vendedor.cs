using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoTecnica1
{
     public class Vendedor
    {
       
        public int Id { get; set; }

        
        public double Valor { get; set; }

        public int TotalVendas { get; set; }

        public double SomaValores { get; set; }

        public double Comissao { get; set; }

        public Vendedor()
        {
        }

       

        public Vendedor( double valor)
        {
            
           
            Valor = valor;
          
        }

        public void SomaVendas()
        {
            TotalVendas ++;

            
        }

        public void SomarValores(double venda)
        {
            double soma = SomaValores + venda;
            SomaValores = soma;
           
        }

        public double CalcularComissao()
        {
            double comissao;
            if (TotalVendas <= 5)
            {
                comissao = SomaValores * 0.004;
                Comissao = comissao;

            }
            if (TotalVendas >= 6 && TotalVendas <= 10)
            {
                comissao = SomaValores * 0.013;
                Comissao = comissao;
            }
            if (TotalVendas >= 11 && TotalVendas <= 15)
            {
                comissao = SomaValores * 0.03;
                Comissao = comissao;
            }
            if (TotalVendas >= 16)
            {
                comissao = SomaValores * 0.05;
                Comissao = comissao;
            }
            return Comissao;
        }

        

        public override string ToString()
        {
            return "Id do vendedor: " + Id + " | " + "Valor total das vendas: " +
                SomaValores + " | " + "Total de vendas: " + TotalVendas + " | " +
                "Comissão total: " + CalcularComissao(); 
        }



    }

    



}
