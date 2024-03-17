using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badEvaluation = int.Parse(Console.ReadLine());

            string nameOfTask = "";
            string evaluation = "";
            int countBadEvaul = 0;
            double sumOfEvaulation = 0;
            double countEvaulation = 0;
            double countTask = 0;
            string lastTask = "";

            while (badEvaluation != countBadEvaul)
            {
                nameOfTask = Console.ReadLine();

                if (nameOfTask == "Enough")
                {
                    Console.WriteLine($"Average score: {sumOfEvaulation / countEvaulation:f2}");
                    Console.WriteLine($"Number of problems: {countTask}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }
                evaluation = Console.ReadLine();
                countEvaulation++;

                double parsocen = double.Parse(evaluation);
                sumOfEvaulation += parsocen;
                if (parsocen <= 4)
                {
                    countBadEvaul++;
                }
                countTask++;
                lastTask = nameOfTask;
            }

            if (nameOfTask == "Enough")
            {

            }
            else
            {
                Console.WriteLine($"You need a break, {countBadEvaul} poor grades.");
            }
        }
    }
}
