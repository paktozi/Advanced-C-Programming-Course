


namespace LineNumbers
{
    using System;
    using System.Diagnostics.Metrics;
    using System.Reflection;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new();
            string[] text = File.ReadAllLines(inputFilePath);


            for (int i = 0; i < text.Length; i++)
            {
                int countLetter = text[i].Count(x => char.IsLetter(x));
                int countPunct = text[i].Count(y => char.IsPunctuation(y));
                sb.AppendLine($"Line {i + 1}: " + text[i] +$" ({countLetter})({countPunct})");

                File.WriteAllText(outputFilePath, sb.ToString());
            }
        }

        //public static int[] Counter(string[] text)
        //{
        //    int counterLetter = 0;
        //  int countrerSince = 0;
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        char[] sym = new char[text[i].Length];
        //        foreach (var c in sym)
        //        {
        //            if (char.IsLetter(c))
        //            {
        //                counterLetter++;
        //            }
        //            else
        //            {
        //                countrerSince++;
        //            }
        //        }

        //    }
        //    int[]count= new int[2];
        //    count[0]= counterLetter;
        //    count[1] = countrerSince;
        //    return count;
        //}


    }
}

