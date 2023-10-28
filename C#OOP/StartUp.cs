using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> classes = new() { "Dog", "Frog", "Cat", "Kitten", "Tomcat" };
            StringBuilder sb = new();

            while (true)
            {
                string input = Console.ReadLine();
                if (classes.Contains(input))
                {
                    if (input == "Dog")
                    {
                        string[] arg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        string name = arg[0];
                        int age = int.Parse(arg[1]);
                        string gender = arg[2];
                        Dog dog = new(name, age, gender);
                        sb.Append(AppendAnimal(input, name, age, gender, dog.ProduceSound()));
                    }
                    else if (input == "Frog")
                    {
                        string[] arg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        string name = arg[0];
                        int age = int.Parse(arg[1]);
                        string gender = arg[2];
                        Frog frog = new(name, age, gender);

                        sb.Append(AppendAnimal(input, name, age, gender, frog.ProduceSound()));
                    }

                    else if (input == "Cat")
                    {
                        string[] arg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        string name = arg[0];
                        int age = int.Parse(arg[1]);
                        string gender = arg[2];
                        Cat cat = new(name, age, gender);

                        sb.Append(AppendAnimal(input, name, age, gender, cat.ProduceSound()));
                    }
                    else if (input == "Kitten")
                    {
                        string[] arg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        string name = arg[0];
                        int age = int.Parse(arg[1]);
                        string gender = arg[2];
                        Kitten kitten = new(name, age);

                        sb.Append(AppendAnimal(input, name, age, gender, kitten.ProduceSound()));
                    }
                    else if (input == "Tomcat")
                    {
                        string[] arg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        string name = arg[0];
                        int age = int.Parse(arg[1]);
                        string gender = arg[2];
                        Tomcat tomcat = new(name, age);

                        sb.Append(AppendAnimal(input, name, age, gender, tomcat.ProduceSound()));
                    }
                }
                else if (input == "Beast!")
                {
                    break;
                }
                else
                {
                    throw new Exception("Invalid input!");
                }
            }
            Console.WriteLine(sb);
        }
        public static string AppendAnimal(string input, string name, int age, string gender, string sound)
        {
            StringBuilder sb = new();
            sb.AppendLine(input);
            sb.AppendLine($"{name} {age} {gender}");
            sb.Append(sound);
            return sb.ToString();
        }
    }
}
