using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(linha[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            int soma = 0;
            for (int j = 0; j < n; j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine(soma);
        }
    }
}
