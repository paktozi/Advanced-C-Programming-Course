namespace _02.SetsofElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nNum = new();
            HashSet<int> mNum = new();
            string input = Console.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);

            for (int i = 0; i < n; i++)
            {
                nNum.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                mNum.Add(int.Parse(Console.ReadLine()));

            }
            nNum.IntersectWith(mNum);

            Console.WriteLine(string.Join(" ", nNum));
        }
    }
}