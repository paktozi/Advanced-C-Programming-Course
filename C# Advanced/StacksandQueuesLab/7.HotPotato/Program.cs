namespace _7.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split());
            int toss = int.Parse(Console.ReadLine());
            int count = 0;

            while (queue.Count != 1)
            {
                count++;
                string kid = queue.Dequeue();
                if (count != toss)
                {
                    queue.Enqueue(kid);
                }
                else
                {
                    Console.WriteLine($"Removed {kid}");
                    count = 0;
                }
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}