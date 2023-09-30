namespace _2.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentList = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                    
                string studentName = input.Split()[0];  
                decimal studentGrade = decimal.Parse(input.Split()[1]);

                if (!studentList.ContainsKey(studentName))
                {
                    studentList[studentName] = new List<decimal>();
                }
                studentList[studentName].Add(studentGrade);
            }

            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x=>$"{x:f2}"))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}