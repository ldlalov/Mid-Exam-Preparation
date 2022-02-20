using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = "";
            int turns = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                turns++;
                List<int> move = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int element1 = move[0];
                int element2 = move[1];

                if (element1 < 0 || element2 < 0 || element1 == element2 || (element1>=elements.Count && elements.Count>0) || (element2 >= elements.Count && elements.Count > 0))
                {
                    elements.Insert(elements.Count / 2, $"-{turns}a");
                    elements.Insert(elements.Count / 2, $"-{turns}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (elements.Count > 0)
                {
                    if (elements[element1] == elements[element2])
                    {
                        string element = elements[element1];
                        elements.Remove(element);
                        elements.Remove(element);
                        Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                if (elements.Count <= 0)
                {
                    Console.WriteLine($"You have won in {turns} turns!");
                    return;
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(' ',elements));
        }
    }
}

