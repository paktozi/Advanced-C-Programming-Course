namespace _2.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int colSum = 0;
                for (int row = 0; row < rows; row++)
                {
                    colSum += matrix[row, col];
                }
                Console.WriteLine(colSum);
            }
        }
    }
}