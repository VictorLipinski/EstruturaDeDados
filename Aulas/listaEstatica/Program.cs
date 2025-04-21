using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticList
{
    class Lista{

        private char[] elementos;
        private int tamanho;
        private int capacidade;

        public Lista(int capacidade) //método
        {
            this.capacidade = capacidade;
            elementos = new char[capacidade];
            tamanho = 0;

        }

        //Inserir no Finaç
        public void Inserir(char valor)
        {
            if (tamanho == capacidade)
            {
                Console.WriteLine("Lista Cheia!");
                return;
            }
            elementos[tamanho] = valor;
            tamanho++;
        }

        //Inserir em uma posição específica
        public void InserirNaPosicao(int pos, char valor)
        {
            if (tamanho == capacidade)
            {
                Console.WriteLine("Lista Cheia!");
                return;
            }
            if (pos < 0 || pos > tamanho)
            {
                Console.WriteLine("Posição Inválida!");
                return;
            }

            for (int i = tamanho; i > pos; i--)
            {
                //['A', 'B', 'C']
                elementos[i] = elementos[i - 1];
                //['A', 'B', 'B' 'C']
            }
            elementos[pos] = valor;
            tamanho++;
        }
        //Remover  por posição
        public void Remover(int pos)
        {
            if (pos < 0 || pos > tamanho)
            {
                Console.WriteLine("Posição inválida!");
            }
            for (int i = pos; i < tamanho - 1; i++)
            {
                //['A', 'X', 'B', 'C']
                elementos[i] = elementos[i + 1];
                //['A', 'B', 'C']
            }
            tamanho--;
        }

        //Exibir os elementos
        public void Exibir()
        {
            if(tamanho == 0)
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            Console.WriteLine("Lista: ");
            for(int i = 0; i < tamanho; i++)
            {
                Console.Write(elementos[i] + " ");
            }
            Console.WriteLine();
        }
        //Retornar tamanho atual da lista
        public int Size()
        {
            return tamanho;
        }

        //Verofocar se a lista está vazia
        public bool Empty()
        {
            return tamanho == 0;
        }

        //Retornar o elemento em uma posição específica
        public char ElementoNaPosicao(int pos)
        {
            if (pos < 0 || pos > tamanho)
            {
                Console.WriteLine("Posição inválida!");
                return '\0';
            }
            return elementos[pos];
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(10);
            int opcao;
            char valor;
            int pos;

            do
            {
                Console.WriteLine("\nLISTA LINEAR ESTÁTICA");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Inserir no final");
                Console.WriteLine("2. Inserir em posição específica");
                Console.WriteLine("3. Remover por posição");
                Console.WriteLine("4. Tamanho da Lista");
                Console.WriteLine("5. Exibir a Lista");
                Console.WriteLine("6. Exibir o elemento da posição");
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
                        Console.WriteLine();
                        lista.Inserir(valor);
                        break;
                    case 2:
                        Console.WriteLine("Digite a posição: ");
                        pos = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Digite a posição para remover");
                        pos = int.Parse(Console.ReadLine());
                        lista.Remover(pos);
                        break;

                    case 4:
                        Console.WriteLine("Tamanho atual: " + lista.Size());
                        break;
                    case 5:
                        lista.Exibir();
                        break;
                    case 6:
                        Console.Write("DIgite a posição: ");
                        pos = int.Parse(Console.ReadLine());
                        valor = lista.ElementoNaPosicao(pos);
                        Console.WriteLine("Elementos: " + valor);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

            } while (opcao != 0);


        }
    }
}
