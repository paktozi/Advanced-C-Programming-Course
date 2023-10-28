using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
       
        int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set 
            { 
                if(value >0)
                {
                   age = value;
                }
            }
        }

        public override string ToString() => $"Name: {this.Name}, Age: {this.Age}";
    }
}
