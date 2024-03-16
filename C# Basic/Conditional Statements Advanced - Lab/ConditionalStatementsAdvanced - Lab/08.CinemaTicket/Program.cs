using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine();

            int ticketPr = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday": ticketPr = 12; break;
                case "Wednesday":
                case "Thursday": ticketPr = 14; break;
                case "Saturday":
                case "Sunday": ticketPr = 16; break;
            }
            Console.WriteLine(ticketPr);
        }
    }
}
