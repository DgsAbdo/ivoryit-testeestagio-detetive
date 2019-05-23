using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();

            // Escreva seu código aqui.

            int aux = 1; //Flag

            do
            {
                Console.Clear();

                try
                {
                    Console.Write("Suspeito: ");
                    int criminoso = int.Parse(Console.ReadLine());

                    Console.Write("\nLocal: ");
                    int local = int.Parse(Console.ReadLine());

                    Console.Write("\nArma: ");
                    int arma = int.Parse(Console.ReadLine());

                    aux = testemunha.Interrogar(criminoso, local, arma);

                    Console.WriteLine("\nRetorno: {0}", aux);

                    if (aux != 0)
                    {
                        if (aux == 3)
                            Console.WriteLine("Arma incorreta.");
                        else if (aux == 2)
                            Console.WriteLine("Local incorreto.");
                        else if (aux == 1)
                            Console.WriteLine("Assassino incorreto.");
                    }
                    else
                        Console.WriteLine("\nVocê acertou!\n");
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opção inválida!");
                }


            } while (Console.ReadKey().Key != ConsoleKey.Escape && aux != 0);

            Console.WriteLine("Número de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
            Console.ReadKey();
        }
    }
}
