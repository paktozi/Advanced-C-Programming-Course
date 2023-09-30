using System.ComponentModel;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new();
            List<int> listA = new();
            List<int> listB = new();
            set.Add(1);
            set.Add(2);
            set.Add(9);
            set.Add(7);
                                 
            listA.Add(1);
            listA.Add(2);
            listA.Add(3);
            listA.Add(4);

            listB.Add(5);
            listB.Add(4);
            listB.Add(2);
            listB.Add(8);

            // listA = listA.Union(listB).ToList();

            // listA=listA.Intersect(listB).ToList();
            set = set.Union(listB).ToHashSet();
            Console.WriteLine(string.Join(" ", set));
        }
    }
}