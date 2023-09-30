namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new();
            using StreamReader reader = new(inputFilePath);

            string text = string.Empty;
            int count = 0;

            while (text != null)
            {
                ReplaceSymbols(sb);
                ReverseWord(sb);
                text = reader.ReadLine();
                if (count % 2 == 0)
                {
                    sb.AppendLine(text);
                }
                count++;
            }

            return sb.ToString();

        }
        public static string ReplaceSymbols(StringBuilder sb)
        {
            char[] chars = { '-', ',', '.', '!', '?' };
            foreach (char c in chars)
            {
                sb.Replace(c, '@');
            }
            return sb.ToString().TrimEnd();
        }
        public static  string ReverseWord(StringBuilder sb)
        {
            string[] word = sb.ToString()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Reverse()
                .ToArray();
            sb.Clear();
            sb.Append(string.Join(" ", word));
           
           
            return string.Join(" ", word);
        }
    }
}



