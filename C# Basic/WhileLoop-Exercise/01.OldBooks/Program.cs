using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int countBook = -1;
            string bookNamesearch = "";

            while (bookNamesearch != "No More Books")
            {
                countBook++;
                bookNamesearch = Console.ReadLine();

                if (bookName == bookNamesearch)
                {
                    Console.WriteLine($"You checked {countBook} books and found it.");
                    break;
                }
            }

            if (bookName == bookNamesearch)
            {

            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBook} books.");
            }
        }
    }
}
