using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___20_Классы__объекты__методы
{
    public class Student
    {
        public string Name;
        public int Age;
        public string Group;

        public Student(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Group: {Group}";
        }
    }
}
