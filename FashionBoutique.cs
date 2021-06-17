namespace FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Stack<int> rackClothes = new Stack<int>();

            List<int> numClothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacityOfRack = int.Parse(Console.ReadLine());

            for (int i = 0; i < numClothes.Count; i++)
                rackClothes.Push(numClothes[i]);

            int numberOfRacks = 1;
            int sumNumber = 0;

            while (rackClothes.Count > 0)
            {
                int newNumber = rackClothes.Peek();
                sumNumber += newNumber;

                if (sumNumber >= capacityOfRack)
                {
                    rackClothes.Pop();
                }
                else 
                {
                    numberOfRacks++;
                    sumNumber = 0;
                }

            }
            Console.WriteLine(numberOfRacks);
        }
    }
}