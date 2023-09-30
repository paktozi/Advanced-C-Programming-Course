

Func<int, int, string,List<int>> oddEven = (start,  end,oddOrEven) =>
{
    List<int> result = new ();
    for (int i = start; i < end; i+=2)
    {
        result.Add(i);
    }
    return result;
};

string input=Console.ReadLine();

int start = int.Parse(input.Split()[0]);
int end = int.Parse(input.Split()[1]);

List<int> result = oddEven(start,end);


Console.WriteLine(string.Join(" ",result));


