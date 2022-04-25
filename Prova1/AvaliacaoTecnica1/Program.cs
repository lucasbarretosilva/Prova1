using System;
using System.Collections.Generic;


namespace AvaliacaoTecnica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            //Produto produto = new Produto();
            List<Vendedor> v = new List<Vendedor>();
            List<Produto> p = new List<Produto>();

            Console.WriteLine("*****************SISTEMA DE VENDAS************************");
            Console.WriteLine("");
            Console.Write("Digite a quantidade de produtos disponíveis: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Digite o Id do vendedor: ");
            vendedor.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------");

            int [] vet = new int [n];
            int quantidade = n;

            for(int i = 0; i < vet.Length; i++) {

               
                Console.WriteLine($"Quantidade restante de produtos: {quantidade}");    
                 Console.Write($"Digite o nome do produto #{i+1}: ");
                 string nomeProduto = Console.ReadLine();
                 Console.Write($"Digite o valor do produto #{i+1}: ");
                 double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------");
                Console.Clear();
               

                 p.Add(new Produto(nomeProduto));
                   
                 v.Add(new Vendedor(valor));
               
                vendedor.SomaVendas();
                vendedor.SomarValores(valor);
                quantidade--;

            }
            Console.WriteLine("-----------------CONSOLIDADO DE VENDAS---------------------");
            Console.WriteLine("");
            Console.WriteLine(vendedor.ToString());
            
          
            
            
            
           
            
           

        }
    }
}
