namespace SquaresinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            int[] size = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] charMatrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    charMatrix[row, col] = input[col];
                }
            }

            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {

                for (int col = 0; col < cols - 1; col++)
                {

                    if (charMatrix[row, col] == charMatrix[row, col + 1] &&
                        charMatrix[row + 1, col] == charMatrix[row + 1, col + 1] &&
                        charMatrix[row, col] == charMatrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
    
