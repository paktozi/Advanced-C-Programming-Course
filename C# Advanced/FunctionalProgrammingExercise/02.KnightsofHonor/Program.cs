


Action<string[]> print = x =>
{
    foreach (var item in x)
    {
        Console.WriteLine($"Sir {item}");
    }
};

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
print(names);