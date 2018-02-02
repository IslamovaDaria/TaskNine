using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskNine;

namespace ConsoleApplication2
{
    class Program
    {
        static int ReadInt()// Ввод целого числа
        {
            int num = 0;
            bool OK = false;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    OK = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Ожидалось натуральное число.");
                    OK = false;
                }
            } while (!OK);
            return num;
        }

        static void Main(string[] args)
        {
            bool OK = true;
            int size;
            int counted_size = 0;
            int counted_size_rec = 0;
            Console.WriteLine("Введите размер списка:");
            {
                size = ReadInt();
                if (size <= 0)
                {
                    Console.WriteLine("Ошибка ввода. Ожидалось натуральное число.");
                    OK = false;
                }
            } while (!OK) ;
            List a = List.MakeListToEnd(size);
            List.ShowList(a);
            counted_size = List.SizeOfList(a);
            Console.WriteLine(counted_size);
            counted_size_rec = List.SizeRec(a);
            Console.WriteLine(counted_size_rec);

            Console.ReadLine();
        }
    }
}
