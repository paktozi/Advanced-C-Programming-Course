namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> counter = new();
            string text = Console.ReadLine();

            foreach (var c in text)
            {
                if (!counter.ContainsKey(c))
                {
                    counter.Add(c, 0);
                }
                counter[c]++;
            }
            foreach (var t in counter)
            {
                Console.WriteLine($"{t.Key}: {t.Value} time/s");
            }
        }
    }
}