namespace _4.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> catalogue = new();
            string input;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string shopName = input.Split(", ")[0];
                string product = input.Split(", ")[1];
                double price = double.Parse(input.Split(", ")[2]);

                if (!catalogue.ContainsKey(shopName))
                {
                    catalogue[shopName] = new Dictionary<string, double>();

                    if (!catalogue[shopName].ContainsKey(product))
                    {
                        catalogue[shopName][product] = price;
                    }
                }

                catalogue[shopName][product] = price;

            }

           // catalogue = catalogue.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var c in catalogue.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{c.Key}->");
                foreach (var v in c.Value)
                {                  
                    Console.WriteLine($"Product: {v.Key}, Price: {v.Value}");
                }
            }
        }
    }
}