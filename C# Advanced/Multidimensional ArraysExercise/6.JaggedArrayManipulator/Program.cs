namespace _6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {

                    for (int c = 0; c < jagged[row].Length; c++)
                    {
                        jagged[row][c] *= 2;
                        jagged[row + 1][c] *= 2;
                    }
                                  
                }
                else
                {
                    for (int c = 0; c < jagged[row].Length; c++)
                    {
                        jagged[row][c] /= 2;
                        jagged[row + 1][c] /= 2;
                    }
                }
                
            }

            foreach (var jr in jagged)
            {
                Console.WriteLine(string.Join(" ", jr));
            }



        }
    }
}