namespace SimpleTextEditor
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (!(1 <= n && n <= 105))
            {
                return;
            }

            Stack<string> text = new Stack<string>();
            string currentTextAndNumber = "";

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(input[0]);
                string textOrNumber = "";
                if (input.Length == 2)
                    textOrNumber = input[1];

                switch (command)
                {
                    case 1:
                        text.Push(textOrNumber);
                        currentTextAndNumber += textOrNumber;
                        break;
                    case 2:
                        text.Push(currentTextAndNumber);
                        int num = int.Parse(textOrNumber);
                        currentTextAndNumber = currentTextAndNumber
                            .Substring(0, currentTextAndNumber.Length - num);
                        break;
                    case 3:
                        int printIndexChar = currentTextAndNumber[int.Parse(textOrNumber) - 1];
                        Console.WriteLine(((char)printIndexChar));
                        break;
                    case 4:
                        currentTextAndNumber = text.Pop();
                        break;
                }
            }
        }
    }
}
