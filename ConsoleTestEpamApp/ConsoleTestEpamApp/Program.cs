using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestEpamApp
{
    class Program
    {
        public 

        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            Tasks task1 = new Tasks();
            task1.Example();



            //Задание 2
            int[] temp = Tasks.Generate10Values();
            Console.WriteLine("\n\n\nЗадание 2\nЗадан следующий массив:");
            temp = Tasks.Sort(temp);
            foreach (var item in temp)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nВведите значение, наличие которого необходимо проверить: ");
            int newValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Данное значение {Tasks.ConvertBool(Tasks.IsContains(temp, newValue))}содержится в заданном массиве");



            //Задание 3
            var task3 = Tasks.Singles("Тестовый текст для проверки третьего задания, кстати, это текст для теста");
            Console.WriteLine("\n\n\nЗадание 3\nДана следующая фраза: Тестовый текст для проверки третьего задания, кстати, это текст для теста");
            foreach (var item in task3)
            {
                Console.Write($"{item} ");
            }


            //Задание 4
            Console.WriteLine("\n\n\nЗадание 4\nВведите число, факториал которого нужно найти:");
            int task4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{task4}! = {Tasks.Factorial(task4)}");



            //Задание 5
            Console.WriteLine("\n\n\nЗадание 5\nДана следующая входная последовательность скобок: (({)(}))");
            string task5 = "(({)(}))";
            Console.WriteLine($"Данная последовательность {Tasks.ConvertBool(Tasks.BracketsAnalizer(task5))}является псп");
        }
    }
}
