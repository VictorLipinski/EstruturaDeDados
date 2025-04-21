using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] nomes = new string[n];
        double[] medias = new double[n];

        for (int i = 0; i < n; i++)
        {
            string[] dados = Console.ReadLine().Split(' ');
            nomes[i] = dados[0];
            double nota1 = double.Parse(dados[1]);
            double nota2 = double.Parse(dados[2]);
            medias[i] = (nota1 + nota2) / 2;
        }

        Console.WriteLine("Alunos aprovados:");
        for (int i = 0; i < n; i++)
        {
            if (medias[i] >= 6)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
