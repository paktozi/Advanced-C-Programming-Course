namespace _4.MatrixShuffling
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] arg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int rowOne = int.Parse(arg[1]);
                int colOne = int.Parse(arg[2]);
                int rowTwo = int.Parse(arg[3]);
                int colTwo = int.Parse(arg[4]);

                if (!arg.Contains("swap")||rowOne<0||rowOne>=rows|| rowTwo < 0 || rowTwo >= rows||colOne<0||colOne>=cols|| colTwo < 0 || colTwo >= cols||arg.Length-1!=4)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                  
                string current = matrix[rowOne, colOne];
                string toSwap = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = toSwap;
                matrix[rowTwo, colTwo] = current;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row,col]+" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}