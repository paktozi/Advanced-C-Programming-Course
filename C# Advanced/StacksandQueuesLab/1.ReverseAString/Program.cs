namespace _1.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Stack<char> stack = new Stack<char>(word);
       
            foreach (var c in stack)
            {
                Console.Write(c);
            }
        }
    }
}