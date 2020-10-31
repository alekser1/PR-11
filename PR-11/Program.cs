using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое положительное пятизначное число N (N > 0). 
            //Используя операции деления и определения остатка от деления найти и вывести сумму всех его цифр.

            int  v1, v2, v3, v4, v5;
            int summ;
            try
            {
                Console.WriteLine("Введите пятизначное число");
                int v = System.Convert.ToInt32(Console.ReadLine());
                v5 = v / 10000;
                v4 = (v % 10000) / 1000;
                v3 = (v % 1000) / 100;
                v2 = (v % 100) / 10;
                v1 = v % 10;
                summ = v1 + v2 + v3 + 4 + v5;

                Console.WriteLine("Сумма всех его цифр:{0}", summ);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Нельзя вводить такое значение");
            }

            //Дано целое положительное четырехзначное ненулевое число N (N>0). 
            //Проверить истинность высказывания: «Данное число читается одинаково слева направо и справа налево».
            try
            {
                int x1, x2, x3, x4;

                Console.WriteLine("Введите четырехзначное число");
                int x = System.Convert.ToInt32(Console.ReadLine());
                x1 = x % 10;
                x2 = (x % 100) / 10;
                x4 = x / 1000;
                x3 = (x % 1000) / 100;

                if (x1 == x4 && x2 == x3) Console.WriteLine("Да");
                else Console.WriteLine("Нет");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Нельзя вводить такое значение");
            }

            //Дан номер месяца N - целое положительное число в диапазоне от1 до 12 (1 - январь, 2 - февраль, ..., 12 - декабрь). 
            //Определить количество дней в этом месяце для не високосного года.

            try
            {
                Console.WriteLine("Введите номер месяца");
                int i = System.Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("31");
                        break;
                    case 2:
                        Console.WriteLine("28");
                        break;
                    case 3:
                        Console.WriteLine("31");
                        break;
                    case 4:
                        Console.WriteLine("30");
                        break;
                    case 5:
                        Console.WriteLine("31");
                        break;
                    case 6:
                        Console.WriteLine("30");
                        break;
                    case 7:
                        Console.WriteLine("31");
                        break;
                    case 8:
                        Console.WriteLine("31");
                        break;
                    case 9:
                        Console.WriteLine("30");
                        break;
                    case 10:
                        Console.WriteLine("31");
                        break;
                    case 11:
                        Console.WriteLine("30");
                        break;
                    case 12:
                        Console.WriteLine("31");
                        break;
                    default:
                        Console.WriteLine("Нет такого месяца");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Нельзя вводить такое значение");
            }
        }
    }
}
