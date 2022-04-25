using System;

namespace AvaliacaoTecnica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vs = { "RIVOTRIL", "SABUTAMOL" , "DIPIRONA", "PARACETAMOL" };

            Console.WriteLine("****************SISTEMA DE FARMÁCIA**********************");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome do remédio que deseja consultar: ");
            string nome = Console.ReadLine().ToUpper();
            bool achei = false;
           
            
                for (int i = 0; i < vs.Length; i++)
                {
                    if (vs[i] == nome)
                    {
                        Console.WriteLine("Remédio disponível!!");
                    achei = true;

                }
               

                }
            if (!achei)
            {

                Console.WriteLine("Remédio não encontrado!!!");
            }


        }
    }
}
