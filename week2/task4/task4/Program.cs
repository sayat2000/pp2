using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-способ
            //  string path = @"C:\Users\Sayat\Desktop\test\1lvl\2lvl\a.txt";
            //  string path2 = @"C:\Users\Sayat\Desktop\test\www\b.txt";
            //  File.Copy(path, path2 ,true);     //1способом мы просто из txt файла в txt файл , скопировали то что было в path в path2

            //   если true, как в случае выше, файл при копировании перезаписывается.
            //   Если же в качестве последнего параметра передать значение false, то если такой файл уже существует,
            //   приложение выдаст ошибку.

            //  File.Delete(path);                //И после того как скопировали мы удаляем path

            //  2-способ
            //      string path = @"C:\Users\Sayat\Desktop\test\1lvl\2lvl\a.txt";
            //      string path2 = @"C:\Users\Sayat\Desktop\test\www\b.txt";

            //   if (File.Exists(path2))
            //Проверяем есть ли существующий файл , типо , Метод Move нельзя использовать для перезаписи существующего файла.
            //Exists(file): определяет, существует ли файл
            //  {
            //      File.Delete(path2);     //Если есть ,то удаляем.
            //      File.Move(path, path2);    //После файл с path перемещяем в path2
            //      //Move: перемещает файл в новое место

            //  }

            //3-способ

            string a = "Hello!";

            string path2 = @"C:\Users\Sayat\Desktop\test\1lvl\2lvl\a.txt";
            StreamWriter file = new StreamWriter(@"C:\Users\Sayat\Desktop\test\www\b.txt");
            file.Write(a);
            file.Close();
            string path = @"C: \Users\Sayat\Desktop\test\Test.txt";
            if (File.Exists(path2))
            //Проверяем есть ли существующий файл, типa, Метод Move нельзя использовать для перезаписи существующего файла.
            //Exists(file): определяет, существует ли файл
            {
                File.Delete(path2);     //Если есть ,то удаляем.
                File.Move(path, path2);    //После файл с path перемещяем в path2
                                           //Move: перемещает файл в новое место

            }
            Console.WriteLine("Created a file in the directory path, then copied it to the directory path1 and the original has deleted");
            Console.ReadKey();
        }
    }
}
