﻿using System;

namespace _03._AnimalType_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile":
                case "tortoise":
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}