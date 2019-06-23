using System;
using System.Windows.Forms;

namespace Exercise_9
{
    class ListItem
    {
        public ListItem()
        {
            Content = 1;
            NextItem = null;
        }
        public int Content;
        public ListItem NextItem;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9:");
            Console.WriteLine("Напишите рекурсивный метод создания линейного списка, в информационные поля элементов которого последовательно заносятся номера с 1 до N (N водится с клавиатуры). Элементы включаются в список в порядке возрастания: в информационном поле первого элемента списка должно быть записано минимальное значение, а последнего элемента – максимальное. Разработайте рекурсивные методы поиска и удаления элементов списка.");
            Application.Run(new Form1());
        }

        public static void ShowList(ListItem head)
        {
            Console.Write(head.Content + "  ");
            if (head.NextItem != null)
            {
                ShowList(head.NextItem);
            }
            else
            {
                Console.WriteLine();
            }
        }

        public static int IndexOf(ListItem head, int k, ref int i)
        {
            if (head.Content == k)
            {
                return i;
            }
            else
            {
                if (head.NextItem != null)
                {
                    i++;
                    return IndexOf(head.NextItem, k, ref i);
                }
                else
                {
                    return -1;
                }
            }
        }

        public static ListItem Del(ListItem head, int d)
        {
            if (head.Content == d)
            {
                return head.NextItem;
            }
            else if (head.NextItem != null && head.NextItem.Content == d)
            {
                head.NextItem = head.NextItem.NextItem;
                if (head.NextItem != null)
                    Del(head.NextItem, d);
                return head;
            }
            else
            {
                if (head.NextItem != null)
                    Del(head.NextItem, d);
                return head;
            }
        }

        public static void MakeList(int n, ListItem head)
        {
            if (n - 1 > 0)
            {
                head.NextItem = new ListItem() { Content = head.Content + 1 };
                MakeList(n - 1, head.NextItem);
            }
        }
    }
}
