namespace _2.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string input;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] command = input.Split();

                if (command.Contains("add"))
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command.Contains("remove"))
                {
                    int n = int.Parse(command[1]);

                    if (stack.Count-n >=0)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            if(stack.Count > 0)
            {
                Console.WriteLine($"Sum: {stack.Sum()}");
            }    
        }
    }
}