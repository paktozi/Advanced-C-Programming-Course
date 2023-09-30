namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clotherInput = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                for (int k = 0; k < clotherInput.Length; k++)
                {
                    string clother = clotherInput[k];

                    if (!wardrobe[color].ContainsKey(clother))
                    {
                        wardrobe[color][clother] = 0;
                    }
                    wardrobe[color][clother]++;
                }
            }

            string[] searchedDress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = searchedDress[0];
            string searchedColther = searchedDress[1];

            foreach (var w in wardrobe)
            {
                bool isFind = false;
                Console.WriteLine($"{w.Key} clothes:");
                if (w.Key == searchedColor)
                {
                    isFind = true;
                }
                foreach (var f in w.Value)
                {
                    if (f.Key == searchedColther && isFind)
                    {
                        Console.WriteLine($"* {f.Key} - {f.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {f.Key} - {f.Value}");
                    }
                }
            }
        }
    }
}