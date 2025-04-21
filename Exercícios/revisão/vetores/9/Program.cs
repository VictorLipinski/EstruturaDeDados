using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int lucroAbaixo10 = 0, lucroEntre10e20 = 0, lucroAcima20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

        for (int i = 0; i < n; i++)
        {
            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            double precoCompra = double.Parse(dados[1]);
            double precoVenda = double.Parse(dados[2]);

            double lucro = precoVenda - precoCompra;
            double percentualLucro = (lucro / precoCompra) * 100;

            totalCompra += precoCompra;
            totalVenda += precoVenda;
            lucroTotal += lucro;

            if (percentualLucro < 10)
            {
                lucroAbaixo10++;
            }
            else if (percentualLucro >= 10 && percentualLucro <= 20)
            {
                lucroEntre10e20++;
            }
            else
            {
                lucroAcima20++;
            }
        }

        Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo10}");
        Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Lucro acima de 20%: {lucroAcima20}");
        Console.WriteLine($"Valor total de compra: {totalCompra:F2}");
        Console.WriteLine($"Valor total de venda: {totalVenda:F2}");
        Console.WriteLine($"Lucro total: {lucroTotal:F2}");
    }
}
