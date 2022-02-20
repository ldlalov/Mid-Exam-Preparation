using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            bool isFull = true;
            int[] lift = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i]<4)
                {
                    int capacity = 4 - lift[i];
                    if (people> capacity)
                    {
                    people -= capacity;
                    lift[i] += capacity;
                    }
                    else if (people<=capacity && people>=0)
                    {
                        lift[i] += people;
                        people = 0;
                    }
                }
            }
            foreach (int vagon in lift)
            {
                if (vagon!=4)
                {
                    isFull = false;
                }
            }
            if (people==0)
            {
                if (isFull)
                {
                    Console.WriteLine(String.Join(' ', lift));
                }
                else
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(String.Join(' ', lift));
                }
            }
            if (people>0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(' ', lift));
            }
        }
    }
}
