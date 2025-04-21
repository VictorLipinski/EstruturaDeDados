using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;

            while ((line = Console.ReadLine()) != null)
            {
                if (line == "0") break;

                int[] desired = line.Split().Select(int.Parse).ToArray();
                Stack<int> station = new Stack<int>();
                int current = 1;
                bool possible = true;

                foreach (int wagon in desired)
                {
                    while (current <= n && (station.Count == 0 || station.Peek() != wagon))
                        station.Push(current++);

                    if (station.Peek() == wagon)
                        station.Pop();
                    else
                    {
                        possible = false;
                        break;
                    }
                }

                Console.WriteLine(possible ? "Yes" : "No");
            }

            Console.WriteLine();
        }
    }
}
