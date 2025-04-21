using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        Stack<int> minStack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();

            if (parts[0] == "PUSH")
            {
                int value = int.Parse(parts[1]);
                stack.Push(value);

                if (minStack.Count == 0 || value <= minStack.Peek())
                    minStack.Push(value);
            }
            else if (parts[0] == "POP")
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("EMPTY");
                }
                else
                {
                    int removed = stack.Pop();
                    if (removed == minStack.Peek())
                        minStack.Pop();
                }
            }
            else if (parts[0] == "MIN")
            {
                if (minStack.Count == 0)
                {
                    Console.WriteLine("EMPTY");
                }
                else
                {
                    Console.WriteLine(minStack.Peek());
                }
            }
        }
    }
}
