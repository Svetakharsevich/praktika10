using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_10
{
    internal class Program
    {
        static void zad1()
        {
            Console.WriteLine("Введите месяц");
            DateTime df = DateTime.Parse(Console.ReadLine());
            int month = df.Month;
            int year = DateTime.Now.Year;
            int count = 0, count1 = 0;
            int month1 = DateTime.DaysInMonth(year, month);
            DateTime date = new DateTime(year, month, 1);
            int i = 0, j = 0;
            double max = 0;
            Console.WriteLine("Введите количество работников");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            int m = Convert.ToInt32(Console.ReadLine());
            double[,] mas = new double[n, m];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите день рождения {i + 1} работника");
                string s = Console.ReadLine();
                DateTime dt = DateTime.Parse(s);
                Console.WriteLine(dt);
                max = mas[i, 0];
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine($"Введите зарплату {i + 1} работника {j + 1} месяца");
                    mas[i, j] = double.Parse(Console.ReadLine());
                    if (mas[i, j] > max) max = mas[i, j];
                    i = 0;
                    j = 0;
                    Console.WriteLine($"Какой график у {i + 1} работника в {j + 1} месяце: обычный или 2/2?");
                    string grafik = Console.ReadLine();
                    if (grafik == "обычный")
                    {
                        while (true)
                        {
                            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                            {
                                count++;
                            }
                            date = date.AddDays(1.0);
                            if (date.Month != month)
                            {
                                break;
                            }
                        }
                        j = 0;
                        Console.WriteLine($"Количество рабочих дней {j + 1} месяце: {month1 - count}");
                        Console.WriteLine($"Количество выходных {j + 1} месяце: {count}");
                    }
                    if (grafik == "2/2")
                    {

                        while (true)
                        {
                            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                            {
                                count1++;

                            }
                            count1 = month1 / 2;
                            date = date.AddDays(1.0);
                            if (date.Month != month)
                            {
                                break;
                            }
                        }
                        j = 0;
                        Console.WriteLine($"Количество рабочих дней в {j + 1} месяце : {month1 - count1}");
                        Console.WriteLine($"Количество выходных {j + 1} месяце: {count1}");
                    }
                    else Console.WriteLine("Такого нет графика");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Максимальная зарплата 2 работника {max}");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} работник\t");


                for (j = 0; j < m; j++)
                {
                    Console.Write($"{j + 1} месяц\t");
                    Console.Write("{0}\t", mas[i, j]);
                }

                Console.WriteLine();
            }
        }
        static void zad5()
        {
            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Мне {0}", age);
            int z = age % 10;
            if (z >= 5 && z <= 9 || z == 0)
                Console.Write(" лет");
            else if (z >= 2 && z <= 4) Console.Write(" года");
            else if (z == 1) Console.Write(" год");
            else if (age == 11 || age == 12 || age == 13 || age == 14 || age == 15) Console.Write(" лет");

        }
        static void zadanie5()
        {
            Console.WriteLine("Введите день");
            int  day=Convert.ToInt32(Console.ReadLine());
            if (day > 31 || day < 0) Console.WriteLine("Нужно ввести день от 1 до 31");
            else
            {   
                   Console.WriteLine("Введите номер месяца");
                   int month=Convert.ToInt32(Console.ReadLine());
                if (month > 12 || month <= 0) Console.WriteLine("Неправильно введен номер месяца");
                else
                {
                    if (month == 1)
                        Console.WriteLine("Месяц под номером " + month + " : Январь");
                    if (month == 2)
                        Console.WriteLine("Месяц под номером " + month + " : Февраль");
                    if (month == 3)
                        Console.WriteLine("Месяц под номером " + month + " : Март");
                    if (month == 4)
                        Console.WriteLine("Месяц под номером " + month + " : Апрель");
                    if (month == 5)
                        Console.WriteLine("Месяц под номером " + month + " : Май");
                    if (month == 6)
                        Console.WriteLine("Месяц под номером " + month + " : Июнь");
                    if (month == 7)
                        Console.WriteLine("Месяц под номером " + month + " : Июль");
                    if (month == 8)
                        Console.WriteLine("Месяц под номером " + month + " : Август");
                    if (month == 9)
                        Console.WriteLine("Месяц под номером " + month + " :  Сентябрь");
                    if (month == 10)
                        Console.WriteLine("Месяц под номером " + month + " : Октябрь");
                    if (month == 11)
                        Console.WriteLine("Месяц под номером " + month + " : Ноябрь");
                    if (month == 12)
                        Console.WriteLine("Месяц под номером " + month + " : Декабрь");
                    Console.ReadKey();
                }
                
            }
        }
        static void v9()
        {
            Console.WriteLine("Введите сколько столбцов в массиве:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько строк в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            if (M != N) Console.WriteLine("Массив должен быть матрицей");
            else
            {


                int[,] massiv = new int[N, M];
                Random rd = new Random();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        massiv[i, j] = rd.Next(0, 10);
                        Console.Write("{0}\t", massiv[i, j]);


                    }
                    Console.WriteLine();
                }
                int count = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = i + 1; j < M; j++)
                    {
                        if (j > i)
                        {
                            if (massiv[i, j] == 0) count++;
                        }

                    }
                }
                Console.WriteLine($"Количество нулевых элементов в массиве = {count}");

                int countn = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = N - i; j < N; j++)
                    {
                        if (massiv[i, j] % 2 == 1) countn++;

                    }
                }
                Console.WriteLine($"Количество нечетных элементов в массиве = {countn}");
                Console.ReadKey();
            }
        }
        static void v14()
        {
            int M = 10;//строки
            int N = 36;//столбцы
            int[,] matrix = new int[M, N];
            Random rand = new Random();
            for (int i = 0; i < M; i++)
            {
                Console.Write($"{i + 1} номер вагона\t");
                Console.WriteLine();

                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(0, 2);
                    Console.Write("{0}\t", matrix[i, j]);


                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите номер вагодна");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] == 0) count++;
                }

            }
            Console.WriteLine($"Вагон {n} свободных мест = {count}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //zad5();
            zadanie5();
            //zad1();
            //v9();
            //v14();
            Console.ReadKey();

        }
    }
}
