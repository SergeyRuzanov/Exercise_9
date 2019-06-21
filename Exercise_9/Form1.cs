using System;
using System.Windows.Forms;

namespace Exercise_9
{
    public partial class Form1 : Form
    {
        ListItem list = new ListItem();
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Список:");
            Program.ShowList(list);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                Program.MakeList((int)numericUpDown1.Value, list);
                Program.ShowList(list);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                int i = 0;
                int searchIndex = Program.IndexOf(list, (int)numericUpDown2.Value, ref i);

                if (searchIndex >= 0)
                    Console.WriteLine($"Индекс элемента: {searchIndex}.");
                else
                    Console.WriteLine("Элемент не найден.");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                int index = (int)numericUpDown2.Value;
                if (index >= 0)
                {
                    list = Program.Del(list, index);
                    Program.ShowList(list);
                }
            }
        }
    }
}
