using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int t = 0; t < n; t++)
        {
            string line = Console.ReadLine().Replace(".", "");
            int diamonds = 0;
            int open = 0;

            foreach (char c in line)
            {
                if (c == '<')
                    open++;
                else if (c == '>' && open > 0)
                {
                    diamonds++;
                    open--;
                }
            }

            Console.WriteLine(diamonds);
        }
    }
}
