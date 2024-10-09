using System;

namespace KARABAS
{
    internal class Program
    {                                              // Здравствуйте
        static void Main(string[] args)              // Запустите код
        {
            Console.WriteLine("Для выхода введите 0");
            string x = "11";
            while (x != "0")
            {
                Console.Write("Введите номер задания:");
                x = Console.ReadLine();
                Console.WriteLine();
                if (x != "0")
                {
                    Console.WriteLine("Задание " + x);
                }
                else break;
                if (x == "1")
                {
                    Console.WriteLine((Convert.ToSingle(Console.ReadLine()) * 1000 / Convert.ToUInt32(Console.ReadLine()) * 60));
                }
                else if (x == "2")
                    Console.WriteLine(Convert.ToInt32(Console.ReadLine() + Console.ReadLine()));
                else if (x == "3")
                {
                    ushort maxu = ushort.MaxValue;
                    short mins = short.MinValue;
                    Console.WriteLine("Максимальное значения для переменной типа ushort " + maxu);
                    Console.WriteLine("Минимальное значение для переменной типа short " + mins);
                }
                else if (x == "4")
                {
                    var v = 7;
                    int i = 5;
                    (i, v) = (v, i);
                    Console.WriteLine("Неявно " + v);
                    Console.WriteLine("Явно " + i);
                }
                else if (x == "5")
                {
                    Console.WriteLine("Task 5");

                    const float p1 = (1.55f);
                    double p2 = (0.77);
                    p2 = 2.5;
                    Console.WriteLine("Нельзя изменить значение константы Float");
                    Console.WriteLine("Зато можно изменить значение простой переменной типа Double");
                }
                else if (x == "6")
                {
                    int i = 18;
                    float f = 16.4f;
                    double d = 5.7;

                    var summa = ((float)i + f + (float)d);
                    var proizv = (int)((float)i * f * (float)d);
                    var proizv2 = (i * (int)f * (int)d);
                    Console.WriteLine("Пункт 2 - " + summa);
                    Console.WriteLine("Пункт 3 - " + proizv);
                    Console.WriteLine("Пункт 4 - " + proizv2);
                }
                else if (x == "7")
                {
                    int a = 2;
                    int b = 3;
                    Console.WriteLine((a + 4 * b) * (a - 3 * b) + 2 * a);
                }
                else if (x == "8")
                {
                    float c = 1.75f;
                    float d = 3.25f;
                    float j = (2 * (c + 1) * 2 + 3 * (d + 1));
                    Console.WriteLine(j);
                }
                else if (x == "9")
                {
                    Console.WriteLine("При len = 5:");
                    const int len = 5;
                    const int kvadrat = len * len;
                    const double okr = Math.PI * len * len;
                    const double proizv = okr * okr;
                    Console.WriteLine("Площадь квадрвта = " + kvadrat);
                    Console.WriteLine("Длина окружности = " + okr);
                    Console.WriteLine("произведение = " + proizv);

                }
                else if (x == "10")
                {
                    string s = "XXX";
                    const char ch = 'c';
                    int i = 7;
                    int n = 10;
                    string kasha = (s + ch + (i+10));
                    Console.WriteLine(kasha);

                }
            }
        }
    }
}
