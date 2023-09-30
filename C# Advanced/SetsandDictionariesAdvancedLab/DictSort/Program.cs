namespace DictSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string,int>age = new Dictionary<string,int>();

            age.Add("ivo", 41);
            age.Add("vera", 34);
            age.Add("alex", 9);
            age.Add("aa", 9);
            

            age = age.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var a in age)
            {
                Console.WriteLine($"{a.Key}-{a.Value}");
            }



        }
    }
}