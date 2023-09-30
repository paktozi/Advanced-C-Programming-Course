


Func<HashSet<int>, int> smallest = (HashSet<int> x) =>
{   
    return x.Min();
};

HashSet<int> result = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToHashSet();
Console.WriteLine(smallest(result));


