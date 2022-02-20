using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmd = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmd[0])
                {
                    case "Add Book":
                        string book = cmd[1];
                        if (!books.Contains(book))
                        {
                            books.Insert(0, book);
                        }
                        break;
                    case "Take Book":
                        book = cmd[1];
                        if (books.Contains(book))
                        {
                            books.Remove(book);
                        }
                        break;
                    case "Swap Books":
                        string book1 = cmd[1];
                        string book2 = cmd[2];
                        int book1Index = -1;
                        int book2Index = -1;
                        if (books.Contains(book1) && books.Contains(book2))
                        {
                            string temp = book1;
                            book1Index = books.IndexOf(book1);
                            book2Index = books.IndexOf(book2);
                            books[book1Index] = book2;
                            books[book2Index] = temp;
                            book1 = book2;
                            book2 = temp;
                        }    
                        break;
                    case "Insert Book":
                        book = cmd[1];
                        if (!books.Contains(book))
                        {
                            books.Add(book);
                        }
                        break;
                    case "Check Book":
                        int index = int.Parse(cmd[1]);
                        if (index>=0 && index<books.Count)
                        {
                            Console.WriteLine($"{books[index]}");
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",books));
        }
    }
}
