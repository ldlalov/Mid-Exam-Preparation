using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                switch (cmd[0])
                {
                    case "swap":
                        int index1 = int.Parse(cmd[1]);
                        int index2 = int.Parse(cmd[2]);
                        int temp = a1[index1];
                        a1[index1] = a1[index2];
                        a1[index2] = temp;
                        break;
                    case "multiply":
                         index1 = int.Parse(cmd[1]);
                         index2 = int.Parse(cmd[2]);
                        a1[index1] = a1[index1] * a1[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < a1.Length; i++)
                        {
                            a1[i]--;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",a1));
        }
    }
}
