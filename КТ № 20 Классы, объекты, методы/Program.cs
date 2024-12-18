using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___20_Классы__объекты__методы
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Иван Петров", 18, "ИВТ-21");
            Student student2 = new Student("Мария Иванова", 19, "ЭК-22");
            Student student3 = new Student("Сергей Сидоров", 20, "ФИТ-21");

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.ReadKey(); // Задержит консоль, чтобы вы смогли увидеть вывод
        }
    }
}
