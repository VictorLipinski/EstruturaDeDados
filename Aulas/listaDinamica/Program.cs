using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
 

    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> lista = new List<char>();
            int opcao;
            char valor;

            do
            {
                Console.WriteLine("\nLISTA LINEAR ESTÁTICA");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir Lista");
                Console.WriteLine("4. Verificar se contém na lista");
                Console.WriteLine("5. Tamanho da Lista");
                Console.WriteLine("6. Limpar Lista");
                Console.WriteLine("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        Console.WriteLine("Digite o valor: ");
                        valor = Console.ReadKey().KeyChar;
                        lista.Add(valor);
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor a ser removido: ");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (lista.Remove(valor))
                            Console.WriteLine("Valor removido com sucesso");
                        else
                            Console.WriteLine("Valor não encontrado");
                        break;
                    case 3:
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("Lista Vazia.");
                        }
                        else
                        {
                            Console.Write("Lista: ");
                            foreach (char c in lista)
                            {
                                Console.Write(c + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite o valor a ser verificado: ");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine(
                            //if ternário
                             lista.Contains(valor) //teste lógico
                            ? "Valor encontrado na lista"//valor se veridadeiro - true
                            : "Valor não encontrado"//valor se falso - else
                            );
                        break;
                    case 5:
                        Console.WriteLine("Tamanho da Lista: " + lista.Count);
                        break;
                    case 6:
                        lista.Clear();
                        Console.WriteLine("Lista limpa");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

            } while (opcao != 0);

        }
    }
}
