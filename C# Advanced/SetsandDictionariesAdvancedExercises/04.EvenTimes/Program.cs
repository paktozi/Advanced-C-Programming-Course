namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(num))
                {
                    numbers[num] = 0;
               //numbers.Add(num,0); 
                }
                numbers[num]++;
            }
            int result = numbers.Single(x => x.Value % 2 == 0).Key;
            //foreach (var allNum in numbers)
            //{
            //    if (allNum.Value % 2 == 0)
            //    {
            //        Console.WriteLine(allNum.Key);
            //    }
            //}
            Console.WriteLine(result);
        }
    }
}