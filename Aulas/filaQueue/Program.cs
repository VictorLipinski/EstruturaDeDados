using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> queue = new Queue<char>();
            int opcao;
            char valor;

            do
            {
                Console.WriteLine("FILA USANDO Queue");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Enfileirar");
                Console.WriteLine("2. Início");
                Console.WriteLine("3. Desenfileirar");
                Console.WriteLine("4. SIZE");
                Console.WriteLine("5. Exibir fila");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    case 1:
                        Console.WriteLine("Digite um valor a ser enfileirado: ");
                        valor = Console.ReadKey().KeyChar;
                        queue.Enqueue(valor);
                        Console.WriteLine();
                        break;

                    case 2:
                        if (queue.Count > 0)
                            Console.WriteLine("Início da fila: " + queue.Peek());
                        else
                            Console.WriteLine("Fila vazia.");
                        break;

                    case 3:
                        if (queue.Count > 0)
                            Console.WriteLine("Elemento desenfileirado: " + queue.Dequeue());
                        else
                            Console.WriteLine("Fila vazia.");
                        break;

                    case 4:
                        Console.WriteLine("Quantidade de elementos na fila: " + queue.Count);
                        break;

                    case 5:
                        Console.Write("Fila: ");
                        foreach (var item in queue)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

            } while (opcao != 0);
        }
    }
}