using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class ListItem
    {
        public ListItem()
        {
            Content = 0;
            NextItem = null;
        }
        public int Content;
        public ListItem NextItem;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;//TODO доделать интерфейс
            ListItem head = new ListItem() { Content = 1 };
            MakeList(N, head);
            ShowList(head);
            head = Del(head, 8);
            ShowList(head);
            int i = 0;
            Console.WriteLine(IndexOf(head, 4, ref i));
            Console.ReadLine();
        }

        static void ShowList(ListItem head)
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

        static int IndexOf(ListItem head, int k, ref int i)
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

        static ListItem Del(ListItem head, int d)
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

        static void MakeList(int n, ListItem head)
        {
            if (n - 1 > 0)
            {
                head.NextItem = new ListItem() { Content = head.Content + 1 };
                MakeList(n - 1, head.NextItem);
            }
        }
    }
}
