

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {

            string path = @"D:\programs";
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
          
            
           string files=fileInfo.FullName;
            //string[] dir = Directory.GetDirectories(inputFolderPath);
          
            //foreach (string dirPath in dir)
            //{             
            //   Console.WriteLine(dirPath);             
            //}
            return null;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {

        }
    }
}

