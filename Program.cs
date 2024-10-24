using System;
using System.Xml.Schema;

namespace @namespace
{
    internal class Program
    {
        static void N8()  //Дан массив A из 2n элементов. Вычислить A1−A2 + A3−A4 + … +A2n−1 + A2n
        {
            string s = (Console.ReadLine());
            string[] ss = s.Split(' ');
            int[] x = new int[ss.Length];
            int sum = 0;
            for (int i = 0; i < ss.Length; i++)
            {
                x[i] = Convert.ToInt32(ss[i]);
            }
            for (int j = 0, k = 1; j < ss.Length; j++, k *= -1)
            {
                sum += k * x[j];
            }
            Console.WriteLine(sum);
        }
        static void N1()  //.Организовать ввод элементов массива с клавиатуры. 
                          // Размер массива также должен задаваться пользователем. 
                          // Введённый массив вывести на экран.
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            for (int i = 0; i < ss.Length; i++)
            {
                Console.Write(ss[i] + " ");
            }
        }
        static void N2()  // Дан массив из n элементов.
                          // Вывести те элементы, у которых нечётный индекс
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            for (int i = 1; i < ss.Length; i += 2)
            {
                Console.Write(ss[i] + " ");
            }
        }
        static void N3()  //3.Дан массив из n чисел.
                          //Вывести сумму всех элементов массива
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int sum = 0;
            for (int i = 0; i < ss.Length; i++)
            {
                sum += Convert.ToInt32(ss[i]);
            }
            Console.WriteLine(sum);
        }
        static void N4()  //4.Дан массив из n чисел.
                          //Вывести произведение всех ненулевых элементов массива
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int sum = 0;
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i] != "0")
                {
                    if (sum == 0)
                    {
                        sum = 1;
                    }
                    sum *= Convert.ToInt32(ss[i]);
                }
            }
            Console.WriteLine(sum);
        }
        static void N5()  //5.Дан массив из n чисел.
                          //Вывести индекс наибольшего элемента в массиве.
        {

            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int max = -1000000000;
            for (int i = 0; i < ss.Length; i++)
            {
                if (max < Convert.ToInt32(ss[i]))
                {
                    max = Convert.ToInt32(ss[i]);
                }
            }
            Console.WriteLine(max);
        }
        static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine("Для выхода введите 0");
            while (s != "0")
            {
                Console.Write("Введите номер задания для проверки (8, 1, 2, 3, 4, 5) ");
                s = Console.ReadLine();
                Console.WriteLine("Задание " + s);
                if (s == "8") N8();
                else if (s == "1") N1();
                else if (s == "2") N2();
                else if (s == "3") N3();
                else if (s == "4") N4();
                else if (s == "5") N5();
                Console.WriteLine();
            }

        }
    }
}
