using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_tasks
{
    public static class Methods 
    {
        #region Task1
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
                    while (i <= j)
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

        public static int[] AltSort(int[] arr)      //С помощью методов класса Array
        {
            Array.Sort(arr);

            return arr;
        }

        //public int Compare(int d1, int d2)      //Можно и не писать, так как это "не сложный тип"
        //{
        //    if (d1 > d2)
        //    {
        //        return 1;
        //    }
        //    else
        //        if (d1 < d2)
        //    {
        //        return -1;
        //    }
        //    else
        //        return 0;
        //}

        //public List<int> SortList(int[] arr)
        //{
        //    List<int> sortedList = new List<int>(arr);
        //    sortedList.Sort();

        //    return sortedList;
        //}

        //^^^ Закоментированная область демонстрирует реализацию интерфейса IComparer для сравнения сложных типов, 
        //но так как класс статический, то это невозможно. А так как сложных типов в рамках данной задачи нет, то и смысла это писать нет
        #endregion

        #region Task2
        public static bool IsContains(int[] arr, int val)
        {   //Самый примитивный метод решения
            foreach (var item in arr)
            {
                if (item == val)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool OptimalIsContains(int[] arr, int val)
        {   //Метод деления массива на 2 части и проверки в какой части может лежать искомое значение
            int left = 0;
            int right = arr.Length;

            int current = arr.Length / 2;

            while (Math.Abs(left-right) > 1)
            {
                if (val > arr[current])
                {
                    left = current;
                    current = (right - left) / 2;
                }
                else
                    if (val < arr[current])
                {
                    right = current;
                    current = (right - left) / 2;
                }
                else
                {
                    return true; //Остался только вариант с равенством текущего и искомого элементов
                }
            }
            if (val == arr[left] || val == arr[right])
            {
                return true;
            }
            else
            {
                return false;
            }
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
        #endregion

        #region Task3
        public static string Singles(string text)
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

                if (mustRemove)
                {
                    words.RemoveAt(i);
                    --i;
                }
                mustRemove = false;
            }

            string result = "";

            foreach (var item in words)
            {
                result += item + " ";
            }
            return result;
        }

        public static string SinglesByDict(string text)
        {   //Тут через Split и всякие другие удобства
            var dict = new Dictionary<string, int>();

            string[] temp = text.Split(new char[] {' ', ',', '.', '!', '?' }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in temp)  //Смотрим сколько раз встречается каждое слово
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            string result = "";
            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    result += item.Key + " ";
                }
            }

            return result;
        }
        #endregion

        #region Task4
        public static int Factorial(int n)
        {       //По определению
            int temp = 1;
            for (int i = 2; i <= n; i++)
            {
                temp *= i;
            }
            return temp;
        }
        #endregion

        #region Task5
        public static bool BracketsAnalizer(string text)
        {   //В задании нет уточнения по поводу вида строки, потому строки вида "{(})" и "}{" не считаются псп в рамках данной программы
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
        #endregion

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

        public static int[] StringToDigitsArray(string input)
        {
            string[] temp = input.Split(new char[] {' '}, System.StringSplitOptions.RemoveEmptyEntries);
            int[] output = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                output[i] = int.Parse(temp[i]);
            }

            return output;
        }

        public static string BuildOutputString(int[] input)
        {
            string output = "";

            foreach (var item in input)
            {
                output += item + " ";
            }

            return output;
        }
    }
}
