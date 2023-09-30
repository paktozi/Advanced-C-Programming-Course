namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int leftDiag = 0;
            int rightDiag = 0;

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

            for (int row = 0; row < size; row++)
            {
                leftDiag += matrix[row, row];
            }

            int i = 0;
            for (int col = size - 1; col >= 0; col--)
            {
                rightDiag += matrix[i, col];
                i++;
            }
            Console.WriteLine(Math.Abs(leftDiag-rightDiag));         
        }
    }
}