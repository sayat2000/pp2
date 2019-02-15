using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int cnt = 0;
            bool prime = false;        //prime=можно представить так, что эта переменная по факту является (false)
                                       // и если он не prime то его значение станет true , и мы выведем те члены массива
                                       //которые false
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                prime = false;
                if (a[i] <= 1) continue;    //если член массива меньше или равен еднице то их не расматриваем
                else
                    for (int j = 2; j < a[i]; j++)
                        if (a[i] % j == 0) prime = true;   //если член массива не prime то вот тут он станет true
                if (!prime) cnt++;      //считаем сколько у нас prime-ов
            }

            Console.WriteLine(cnt);

            for (int i = 0; i < n; i++)
            {
                prime = false;
                if (a[i] <= 1) continue;    //если член массива меньше или равен еднице то их не расматриваем
                else
                    for (int j = 2; j < a[i]; j++)
                        if (a[i] % j == 0) prime = true;   //если член массива не prime то вот тут он станет true
                if (!prime) Console.Write(a[i] + " ");     //считаем сколько у нас prime-ов
            }
            Console.ReadKey();
        }
    }
}
