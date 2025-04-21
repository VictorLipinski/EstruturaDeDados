using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Pilha
    {
        private char[] elementos;
        private int topo;
        private int tamanho;

        public Pilha(int capacidade)
        {
            elementos = new char[capacidade];
            topo = -1;
            tamanho = 0;
        }

        //Metodo para adicionar um elemento na pilha
        public void Push(char caratere) //push salvar um valor dentro do vetor
        {
            //validações futuras...
            elementos[++topo] = caratere;
            tamanho++;
        }
        //Método para exibir os elementos da pilha
        public void Exibir()
        {
            Console.WriteLine("Pilha: ");
            for(int i = topo; i >= 0; i--)
            {
                Console.WriteLine(" " + elementos[i]);
            }
            Console.WriteLine();
        }

        //Método para retornar o tamanho da pilha

        public int Size()
        {
            return tamanho;
        }

        //Método para obter o elemento do topo da pilha
        public char Top()
        {
            //Validações futuras
            return elementos[topo];
        }
        
        //Método para remover o elemento do topo da pilha
        public char Pop()
        {
            char c = elementos[topo--];
            tamanho--;
            return c; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha(10);
            char opcao;

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Inserir um elemento na pilha: ");
                Console.WriteLine("2 - Remover um elemento da pilha: ");
                Console.WriteLine("3 - Exibir elementos da pilha: ");
                Console.WriteLine("4 - Mostrar o topo da pilha: ");
                Console.WriteLine("5 - Mostra o tamanho da pilha: ");
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadKey().KeyChar; //ler somente 1 caracter
                Console.WriteLine();
                
                switch(opcao)
                {
                    case '1':
                        Console.WriteLine("Digite um caracter para empilhar: ");
                        char caracter = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        pilha.Push(caracter);
                        break;

                    case '2':
                        Console.WriteLine("Elemento removido: " + pilha.Pop());
                        break;

                    case '3':
                        pilha.Exibir();
                        break;

                    case '4':
                        Console.WriteLine("Topo da pilhar: " + pilha.Top());
                        break;

                    case '5':
                        Console.WriteLine("Tamanho da pilha:  " + pilha.Size());
                        break;

                    case '0':
                        Console.WriteLine("Saindo... ");
                        break;

                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }

            } while (opcao !='0');
        }
    }
}
