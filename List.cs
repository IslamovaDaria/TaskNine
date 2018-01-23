using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNine
{
    class List
    {
        public static int count = 0;

        public int data;//информационное поле 
        public List next;//адресное поле 

        public List()//конструктор без параметров 
        {
            data = 0;
            next = null;
        }

        public List(int d)//конструктор с параметрами 
        {
            data = d;
            next = null;
        }

        public override string ToString()
        {
            return data + " ";
        }

        public static List MakePoint(int d) //метод для формирования одного элемента списка 
        {
            List p = new List(d);
            return p;
        }

        public static List MakeListToEnd(int size) //добавление в конец 
        {
            if (size == 0) return null;
            Random rand = new Random();
            int info = rand.Next(100);
            List beg = MakePoint(info);
            List r = beg;
            for (int i = 1; i < size; i++)
            {
                info = rand.Next(100);
                List p = MakePoint(info);
                r.next = p;
                r = p;
            }
            return beg;
        }

        public static void ShowList(List beg)
        {
            List p = beg;
            while (p != null)
            {
                Console.Write(p);
                p = p.next;
            }
            Console.WriteLine();
        }

        public static int SizeOfList(List beg)
        {
            List p = beg;
            while (p != null)
            {
                count++;
                p = p.next;
            }
            return count;
        }

        public static int SizeRec(List beg)
        {
            List p = beg;
            if (p.next == null) return 1;
            return (1 + SizeRec(p.next));
        }
    }
}
