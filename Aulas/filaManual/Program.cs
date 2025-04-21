using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    class Fila
    {
        private char[] elementos;
        private int inicio;
        private int fim;
        private int tamanho;
        private int capacidade;


        //Inicialar a fila com o tamanho que o usuáio passar
        public Fila(int capacidade) //ctr = Delimita os atributos obrigatórios
        {
            this.capacidade = capacidade;
            elementos = new char[capacidade];
            inicio = 0;
            fim = -1;
            tamanho = 0;
        }

        //Enfileirar
        public void Enqueue(char caractere)
        {
            if( tamanho == capacidade)
            {
                Console.WriteLine("Erro: a filá está cheia!");
                return;
            }
            fim = (fim + 1) % capacidade;
            elementos[fim] = caractere;
            tamanho++;
        }

        //Desenfileirar
        public char Dequeue()
        {
            if (Empty())
            {
                Console.WriteLine("A fila está vazia!");
                return '\0';
            }
            char valor = elementos[inicio];
            inicio = (inicio + 1) % capacidade;
            tamanho--;
            return valor;
        }

        //Exibir elementos da fila
        public void Exibir()
        {
            if (Empty())
            {
                Console.WriteLine("A fila está vazia");
                return;
            }
            Console.Write("Fila: ");
            for (int i = 0; i < tamanho; i++)
            {
                int index = (inicio + i) % capacidade;
                Console.Write(elementos[index] + " ");
            }
            Console.WriteLine();
        }

        //Tamanho
        public int Size()
        {
            return tamanho;
        }

        //Ellementos do inicio da Fila
        public char Head()
        {
            return elementos[inicio];
        }

        //Verificar se a fila está vazia

        public bool Empty()
        {
            return tamanho == 0;
        }
        
    }


        internal class Program
        {
            static void Main(string[] args)
            {
                Fila fila = new Fila(10);
                int opcao;
                char valor;

                do
                {
                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine("0. Sair");
                    Console.WriteLine("1. Enfileirar");
                    Console.WriteLine("2. Início");
                    Console.WriteLine("3. Desenfileirar");
                    Console.WriteLine("4. Tamanho do fila");
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
                            fila.Enqueue(valor);
                            Console.WriteLine();
                            break;
                        case 2:
                            valor = fila.Head();
                            Console.WriteLine("Inicio da Fila " + valor);
                            break;
                        case 3:
                            valor = fila.Dequeue();
                            Console.WriteLine("Elemento desenfileirado: " + valor);
                            break;
                        case 4:
                            Console.WriteLine("Quantidade de elementos na fila: " + fila.Size());
                            break;
                        case 5:
                            fila.Exibir();
                            break;
                        default:
                            Console.WriteLine("Opção Inválida!");
                            break;
                    }

                } while (opcao != 0);
            }
        }
}
