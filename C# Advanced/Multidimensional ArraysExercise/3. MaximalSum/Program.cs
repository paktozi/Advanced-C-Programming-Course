namespace _3._MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int max = int.MinValue;
            int rowMax = 0;
            int colMax = 0;
            for (int row = 0; row < rows - 2; row++)
            {

                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = 0;
                    sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                         + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                         + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > max)
                    {
                        max = sum;
                        rowMax = row;
                        colMax = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {max}");

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"{matrix[rowMax+i, colMax]} {matrix[rowMax+i, colMax +1]} {matrix[rowMax+i, colMax +2]}");
            }                    
        }
    }
}