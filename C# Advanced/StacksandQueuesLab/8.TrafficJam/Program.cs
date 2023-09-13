namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int count = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else 
                {
                    for (int i = 0; i < numOfCars&&cars.Count>0; i++)
                    {
                        Console.WriteLine($"{cars.Peek()} passed!");
                        cars.Dequeue();
                        count++;
                    }
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}