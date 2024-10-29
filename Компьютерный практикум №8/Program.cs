using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Условие задачи: вывести нечётные двухзначные числа в столбик, подсчитать их кол-во, найти сумму и среднее арифметическое
            //int count = 0;
            //int sum = 0;
            //int twoDigitNumber = 10;
            //while(twoDigitNumber < 100)
            //{
            //    if(twoDigitNumber % 2 != 0)
            //    {
            //        count++;
            //        sum += twoDigitNumber;
            //        Console.WriteLine(twoDigitNumber);
            //    }
            //    twoDigitNumber++;
            //}
            //
            //for(int twoDigitNumber = 10; twoDigitNumber < 100; twoDigitNumber++)
            //{
            //    if (twoDigitNumber % 2 != 0)
            //    {
            //        count++;
            //        sum += twoDigitNumber;
            //        Console.WriteLine(twoDigitNumber);
            //    }
            //}

            //Console.WriteLine($"Кол-во нечётных двухзначных чисел: {count}\nИх сумма: {sum}.\nИх среднее арифметическое: {sum / count}.");


            //Вывести в обратном порядке двухзначные числа кратные 25.
            //int twoDigitNumber = 99;
            //while(twoDigitNumber >= 10)
            //{
            //    if(twoDigitNumber % 25 == 0)
            //    {
            //        Console.WriteLine(twoDigitNumber);
            //    }
            //    twoDigitNumber--;
            //}
            //for(int twoDigitNumber = 99; twoDigitNumber >= 10; twoDigitNumber--)
            //{
            //    if(twoDigitNumber % 25 == 0)
            //    {
            //        Console.WriteLine(twoDigitNumber);
            //    }
            //}

            //Задача 1. Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.
            //int[] omas = new int[8];
            //Console.WriteLine("Заполнение одномерного массива");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write($"omas[{i}] = ");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Вывод одномерного массива");
            ////for(int i = 0; i < 8; i++)
            ////{
            ////    Console.WriteLine($"omas[{i}] = {omas[i]}");
            ////}
            //foreach (var o in omas)
            //{
            //    Console.WriteLine(o);
            //}

            //Задача 2. Составьте программу ввода (без клавиатуры) и вывода массива: 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3.
            //int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            //Console.WriteLine("Вывод одномерного массива");
            ////for(int i = 0; i < omas.Length; i++)
            ////{
            ////    Console.WriteLine($"omas[{i}] = {omas[i]}");
            ////}
            //foreach (var o in omas)
            //{
            //    Console.WriteLine(o);
            //}

            //Задача 3. Массив предназначен для хранения значений ростов двенадцати человек.
            //С помощью датчика случайных чисел заполнить массив целыми значениями,
            //лежащими в диапазоне от 163 до 190 включительно.
            //Random rnd = new Random();
            //int[] height = new int[12];
            //for(int i = 0; i < height.Length; i++)
            //{
            //    height[i] = rnd.Next(163, 190);

            //}
            //foreach(var element in height)
            //{
            //    Console.Write($"{element}\n");
            //}

            //Условие: Найти средную температуру воздуха за октябрь.
            int[] temps = new int[31];
            Random rnd = new Random();
            int sum = 0;
            for(int i = 0; i < temps.Length; i++)
            {
                temps[i] = rnd.Next(5, 25);
                sum += temps[i];
            }
            Console.WriteLine($"Средняя температура: {sum / temps.Length}");

            Console.ReadKey();
        }
    }
}
