using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int n = int.Parse(Console.ReadLine());
        double[,] mat = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = double.Parse(linha[j], CI);
            }
        }

        int linhaEscolhida = int.Parse(Console.ReadLine());
        int colunaEscolhida = int.Parse(Console.ReadLine());

        double somaPositivos = 0.0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] > 0.0)
                {
                    somaPositivos += mat[i, j];
                }
            }
        }

        Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CI));

        Console.Write("LINHA ESCOLHIDA: ");
        for (int j = 0; j < n; j++)
        {
            Console.Write(mat[linhaEscolhida, j].ToString("F1", CI) + " ");
        }
        Console.WriteLine();

        Console.Write("COLUNA ESCOLHIDA: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(mat[i, colunaEscolhida].ToString("F1", CI) + " ");
        }
        Console.WriteLine();

        Console.Write("DIAGONAL PRINCIPAL: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(mat[i, i].ToString("F1", CI) + " ");
        }
        Console.WriteLine();

        Console.WriteLine("MATRIZ ALTERADA:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] < 0.0)
                {
                    mat[i, j] = mat[i, j] * mat[i, j];
                }
                Console.Write(mat[i, j].ToString("F1", CI) + " ");
            }
            Console.WriteLine();
        }
    }
}
