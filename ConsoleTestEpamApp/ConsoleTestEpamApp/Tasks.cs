using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestEpamApp
{
    class Tasks: IComparer<int>
    {
        private int[] arr;
        private List<int> list;

        public Tasks()
        {
            arr = new int[10];      //В конструторе по умолчанию создаём массив из 10 чисел
            list = new List<int>();
        }

        public Tasks(int[] arr)
        {
            Array.Copy(arr, 0, this.arr/* = new int[arr.Length]*/, 0, arr.Length);
            list = new List<int>(arr);
        }

        public static int[] Sort(int[] arr)        //Алгоритм быстрой нерекурсивной сортировки
        {
            int main = 0;                   //Опорный элемент
            int left = 0;                   //Левая граница
            int right = 0;                  //Правая граница
            int i = 0;
            int j = 0;

            int temp;                       //Временная переменная для обмена значениями

            Stack<int> stack = new Stack<int>();

            stack.Push(arr.Length - 1);
            stack.Push(0);

            while (stack.Count != 0)
            {
                left = stack.Pop();
                right = stack.Pop();

                if (((right - left) == 1) && (arr[left] > arr[right]))
                {
                    temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    main = arr[(left + right) / 2];     //Выбор опорного элемента в середине последовательности
                    i = left;
                    j = right;
                    while(i <= j)
                    {
                        while (main > arr[i])
                        {
                            ++i;
                        }
                        while (main < arr[j])
                        {
                            --j;
                        }
                        if (i <= j)
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            ++i;
                            --j;
                        }
                    }
                }

                if (left < j)
                {
                    stack.Push(j);
                    stack.Push(left);
                }
                if (i < right)
                {
                    stack.Push(right);
                    stack.Push(i);
                }
            }


            return arr;
        }

        public static int[] SortLib(int[] arr)      //С помощью методов класса Array
        {
            Array.Sort(arr);

            return arr;
        }

        public int Compare(int d1, int d2)      //Можно и не писать, так как это "не сложный тип"
        {
            if (d1 > d2)
            {
                return 1;
            }
            else
                if (d1 < d2)
            {
                return -1;
            }
            else
                return 0;
        }

        public static List<int> SortList(int[] arr)
        {
            List<int> sortedList = new List<int>(arr);
            sortedList.Sort();

            return sortedList;
        }

        public void Example()
        {
            Random rand = new Random();

            Console.WriteLine("Сгенерированная последовательность: \n");

            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = rand.Next(0, 1000);
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine("\n");

            int[] tempArr = Sort(mas);
            Console.WriteLine("Результат работы алгоритма: \n");
            foreach (var item in tempArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static bool IsContains(int[] arr, int val)
        {       
            foreach (var item in arr)
            {
                if (item == val)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsContainsList(int[] arr, int val)
        {
            List<int> list = new List<int>(arr);

            if (list.Contains(val))
            {
                return true;
            }
            else
                return false;
        }

        public static int[] Generate10Values()
        {
            int[] mas = new int[10];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                mas[i] = rand.Next(0, 1000);
            }
            return mas;
        }

        public static string ConvertBool(bool temp)
        {
            return ((temp) ? "" : "не ");
        }

        public static int Factorial(int n)
        {
            int temp = 1;               
            for (int i = 2; i <= n; i++)
            {
                temp *= i;
            }
            return temp;
        }

        public static List<string> Singles(string text)
        {
            text += " ";        //Пробел в конце предложения, чтобы добавление последнего слова прошло удачно.
            List<string> words = new List<string>();
            string temp = "";
            bool mustRemove = false;
            foreach (var item in text)          //Режем строку, так как Split всё же готовый метод
            {
                if (Char.IsLetter(item))
                {
                    temp += item;
                }
                else
                {
                    if (temp != "" || temp != " ")
                    {
                        words.Add(temp);
                    }
                    temp = "";
                }
            }
            for (int i = 0; i < words.Count; i++)       //Удаляем все слова, что встретились более 1 раза
            {
                for (int j = i + 1; j < words.Count; j++)
                {
                    if (words[i] == words[j])
                    {
                        words.RemoveAt(j);
                        mustRemove = true;
                    }
                }

                if(mustRemove)
                {
                    words.RemoveAt(i);
                    --i;
                }
                mustRemove = false;
            }
            return words;
        }

        public static bool BracketsAnalizer(string text)
        {   //В задании нет уточнения по поводу вида строки, потому строки "{(})" и "}{" не считаются псп в рамках данной программы
            Dictionary<char, char> dict = new Dictionary<char, char>
            {
                {'[', ']'},
                {'(', ')'},
                {'{', '}'},
            };

            Stack<char> stack = new Stack<char>();

            foreach (var item in text)
            {
                if (dict.ContainsKey(item)) //Если есть открывающая скобка, заносим её в стек
                {
                    stack.Push(item);
                }
                else
                    if (dict[stack.Peek()] == item)
                {
                    stack.Pop();        //Если найдена закрывающая скобка, которая соответствует текущей скобке в стеке, то они удаляются
                }
                else
                    return false;
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
