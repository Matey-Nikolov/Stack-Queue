namespace BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (!(1 <= input.Length && input.Length <= 1000))
            {
                Console.WriteLine("NO");
            }

            Stack<char> openParenthesis = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '{' || currentChar == '(' || currentChar == '[')
                    openParenthesis.Push(currentChar);

                char peekParenthesi = openParenthesis.Peek();

                if (peekParenthesi == '(' && currentChar == ')')
                    openParenthesis.Pop();
                else if (peekParenthesi == '[' && currentChar == ']')
                    openParenthesis.Pop();
                else if (peekParenthesi == '{' && currentChar == '}')
                    openParenthesis.Pop();
            }

            if (openParenthesis.Count == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}