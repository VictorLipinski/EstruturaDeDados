using System;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int balance = 0;
            bool incorrect = false;

            foreach (char c in line)
            {
                if (c == '(')
                    balance++;
                else if (c == ')')
                {
                    if (balance == 0)
                    {
                        incorrect = true;
                        break;
                    }
                    balance--;
                }
            }

            Console.WriteLine(!incorrect && balance == 0 ? "correct" : "incorrect");
        }
    }
}
