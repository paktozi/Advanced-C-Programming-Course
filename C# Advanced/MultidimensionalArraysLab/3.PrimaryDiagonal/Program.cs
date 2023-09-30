namespace _3.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int sum = 0;
            for (int row = 0; row < size; row++)
            {

                for (int col = row; col <= row; col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(sum);
        }
    }
}