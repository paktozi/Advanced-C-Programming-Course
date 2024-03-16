using System;

namespace _08.OnTimefortheExam
{
    internal class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());

            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTotMinutes = examHour * 60 + examMin;
            int arrivalTotMinutes = arrivalHour * 60 + arrivalMinutes;

            if (examTotMinutes < arrivalTotMinutes)
            {
                Console.WriteLine("Late");

                int minuteDiff = arrivalTotMinutes - examTotMinutes;

                if (minuteDiff < 60)
                {
                    Console.WriteLine($"{minuteDiff} minutes after the start");
                }
                else
                {
                    int hours = minuteDiff / 60;
                    int min = minuteDiff % 60;
                    Console.WriteLine($"{hours}:{min:d2} hours after the start");
                }
            }
            else if (arrivalTotMinutes < examTotMinutes - 30)
            {
                Console.WriteLine("Early");
                int minuteDiff = examTotMinutes - arrivalTotMinutes;
                if (minuteDiff < 60)
                {
                    Console.WriteLine($"{minuteDiff} minutes before the start");
                }
                else
                {
                    int hours = minuteDiff / 60;
                    int min = minuteDiff % 60;
                    Console.WriteLine($"{hours}:{min:d2} hours before the start");
                }

            }
            else
            {
                Console.WriteLine("On time");
                int minuteDiff = examTotMinutes - arrivalTotMinutes;
                Console.WriteLine($"{minuteDiff} minutes before the start");

            }
        }
    }
}
