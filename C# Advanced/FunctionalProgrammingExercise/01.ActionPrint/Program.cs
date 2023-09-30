


Action<string[]> print = (string[] x) =>Console.WriteLine(string.Join(Environment.NewLine,x));   
string[] name = Console.ReadLine()
    .Split();
print (name);