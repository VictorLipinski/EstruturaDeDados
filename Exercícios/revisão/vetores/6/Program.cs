using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string nomeMaisVelho = "";
        int idadeMaisVelho = -1;

        for (int i = 0; i < n; i++)
        {
            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            int idade = int.Parse(dados[1]);

            if (idade > idadeMaisVelho)
            {
                idadeMaisVelho = idade;
                nomeMaisVelho = nome;
            }
        }

        Console.WriteLine($"Pessoa mais velha: {nomeMaisVelho}");
    }
}
