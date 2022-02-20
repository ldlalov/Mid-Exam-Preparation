using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                List<string> cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (cmd[0])
                {
                    case "Urgent":
                        string item = cmd[1];
                        if (!shopingList.Contains(item))
                        {
                            shopingList.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        item =cmd[1];
                        if (shopingList.Contains(item))
                        {
                            shopingList.Remove(item);
                        }
                        break;
                    case "Correct":
                        int temp = -1;
                        string oldItem = cmd[1];
                        string newItem = cmd[2];
                        temp = shopingList.IndexOf(oldItem);
                        if (temp != -1)
                        {
                            shopingList[temp] = newItem;
                        }
                        break;
                    case "Rearrange":
                        item = cmd[1];
                        if (shopingList.Contains(item))
                        {
                            shopingList.Remove(item);
                            shopingList.Add(item);
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",shopingList));
        }
    }
}
