using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());  //Ввод размера массива

            int[] a = new int[n];           //Создали массив
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());           //В консоли вводим элементы массива
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");         //Продублировали каждый элемент и вывели
            }
            Console.ReadKey();
        }
    }
}
