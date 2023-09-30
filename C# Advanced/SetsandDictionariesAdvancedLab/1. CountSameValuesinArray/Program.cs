namespace _1._CountSameValuesinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[]number=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> counter = new();

            for (int i = 0; i < number.Length; i++)
            {
                if (!counter.ContainsKey(number[i]))
                {
                    counter.Add(number[i],0);
                    //counter[number[i]] = 0;
                }
                counter[number[i]]++;
            }

            foreach (var c in counter)
            {
                Console.WriteLine($"{c.Key} - {c.Value} times");
            }

        }
    }
}