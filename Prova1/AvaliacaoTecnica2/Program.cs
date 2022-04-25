using System;

namespace AvaliacaoTecnica2
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                int resul = 0;
                int tenta = 1;
                int chute = 0;
                
                 do
                {
                    resul = new Random().Next(1, 15);
                    Console.WriteLine("Digite um número entre 1 e 15: ");
                    chute = int.Parse(Console.ReadLine());

                    if (resul == chute)
                    {
                        Console.WriteLine($"Você acertou em {tenta}: ");
                        Console.Write("Você deseja continuar? Digite n para sair: ");
                        char resp = char.Parse(Console.ReadLine());
                        if(resp == 'n'|| resp == 'N')
                    {
                        break;
                    }
                   
                    
                }
                   
                    else
                    {
                        Console.WriteLine($"Você errou! o número que eu estava pensando era {resul} ");
                        tenta++;
                    Console.Write("Você deseja continuar? (s/n): ");
                    char resp = char.Parse(Console.ReadLine());
                    if (resp == 'n' || resp == 'N')
                    {
                        break;
                    }

                }

                } while (resul != chute);


            }
        
    }
}
