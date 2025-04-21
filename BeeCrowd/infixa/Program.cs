using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int t = 0; t < n; t++)
        {
            string input = Console.ReadLine();
            Console.WriteLine(InfixToPostfix(input));
        }
    }

    static string InfixToPostfix(string expr)
    {
        Stack<char> stack = new Stack<char>();
        string output = "";

        Dictionary<char, int> precedence = new Dictionary<char, int>
        {
            { '+', 1 }, { '-', 1 },
            { '*', 2 }, { '/', 2 },
            { '^', 3 }
        };

        foreach (char token in expr)
        {
            if (char.IsLetterOrDigit(token))
            {
                output += token;
            }
            else if (token == '(')
            {
                stack.Push(token);
            }
            else if (token == ')')
            {
                while (stack.Peek() != '(')
                    output += stack.Pop();
                stack.Pop();
            }
            else
            {
                while (stack.Count > 0 && stack.Peek() != '(' &&
                      ((precedence.ContainsKey(token) && precedence[token] < precedence[stack.Peek()]) ||
                      (precedence.ContainsKey(token) && precedence[token] == precedence[stack.Peek()] && token != '^')))
                {
                    output += stack.Pop();
                }
                stack.Push(token);
            }
        }

        while (stack.Count > 0)
            output += stack.Pop();

        return output;
    }
}
