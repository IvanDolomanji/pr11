using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить количество элементов одномерного массива.
            //int[] omas = { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"размер: {omas.Length}");

            //Задача 2.Обнулить заданный диапазон элементов в одномерном массиве.
            //int[] omas = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("массив");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Array.Clear(omas, 2, 2);
            //Console.WriteLine("обнуленный массив");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}

            //Задача 3.Найти максимальное и минимальное значение в массиве.
            //int[] omas = { -1, 2, -3, 4, -5 };
            //int max = omas.Max();
            //int min = omas.Min();
            //Console.WriteLine($"min = {min}, max = {max}");

            //Задача 4.Сортировка массива по возрастанию.
            //int[] omas = { -1, 2, -3, 4, -5 };
            //Array.Sort(omas);
            //foreach (int i in omas)
            //{
            //    Console.WriteLine(i);
            //}

            //Задача 5.Реверс массива.
            //int[] omas = { -1, 2, -3, 4, -5 };
            //Array.Reverse(omas);
            //foreach (int i in omas)
            //{
            //    Console.WriteLine(i);
            //}

            //Задача 6. Подсчет количества вхождений определенного числа в массив.
            //int[] omas = { 1, 2, 3, 4, 5, 2, 2, 6, 7, 2 };
            //Console.Write("Введите число для подсчета: ");
            //int i = int.Parse(Console.ReadLine());
            //int count = Array.FindAll(omas, x => x == i).Length;
            //Console.WriteLine($"Число {i} встречается {count} раза в массиве.");

            //Задача 7.Поиск элемента по условию.
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Элементы массива, которые больше 5:");
            //foreach (int num in array)
            //{
            //    if (num > 5)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    Console.ReadKey();


                //Задача 8. Изменение размера массива.
                //int[] omas = { -1, 2, -3, 4, -5 };
                //Array.Resize(ref omas,10);
                //foreach (int el in omas)
                //{
                //    Console.WriteLine(el);
                //}

                //Задача 9.Поиск индекса элемента.
                //int[] array = { 10, 20, 30, 40, 50, 60 };
                //Console.Write("Введите число для поиска индекса: ");
                //int n = int.Parse(Console.ReadLine());
                //int index = Array.FindIndex(array, x => x == n);
                //if (index >= 0)
                //    Console.WriteLine($"Индекс элемента {n}: {index}");
                //else
                //    Console.WriteLine("Элемент не найден.");
                //Console.ReadKey();

                //Задача 10.Удаление всех четных элементов из массива.
                //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //array = array.Where(x => x % 2 != 0).ToArray();
                //Console.WriteLine("Массив после удаления четных элементов:");
                //foreach (int num in array)
                //{
                //    Console.Write(num + " ");
                //}
                //Console.ReadKey();


                //Задача 11.Сумма всех элементов массива.
                //Console.Write("Введите количество элементов массива: ");
                //int n = int.Parse(Console.ReadLine());
                //int[] array = new int[n];
                //Console.WriteLine("Введите элементы массива:");
                //for (int i = 0; i < n; i++)
                //{
                //    array[i] = int.Parse(Console.ReadLine());
                //}
                //int sum = 0;
                //foreach (int num in array)
                //{
                //    sum += num;
                //}
                //Console.WriteLine("Сумма всех элементов массива: " + sum);
                //Console.ReadKey();

                //Задача 12.Умножение всех элементов массива на определенное число.
                //Console.Write("Введите количество элементов массива: ");
                //int n = int.Parse(Console.ReadLine());
                //int[] array = new int[n];
                //Console.WriteLine("Введите элементы массива:");
                //for (int i = 0; i < n; i++)
                //{
                //    array[i] = int.Parse(Console.ReadLine());
                //}
                //Console.Write("Введите число, на которое нужно умножить все элементы массива: ");
                //int multiplier = int.Parse(Console.ReadLine());
                //for (int i = 0; i < n; i++)
                //{
                //    array[i] *= multiplier;  
                //}
                //Console.WriteLine("Массив после умножения элементов:");
                //foreach (int num in array)
                //{
                //    Console.Write(num + " ");
                //}
                //Console.ReadKey();

                //13 Заполните одномерный массив числовыми данными случайным образом из промежутка [ - 50;50].
                //Подсчитайте количество элементов массива, кратных 3 (размерность массива равна 15).
                //int n = 15;
                //int[] array = new int[n];
                //Random random = new Random();
                //for (int i = 0; i < n; i++)
                //{
                //    array[i] = random.Next(-50, 51); 
                //}
                //int countMultiplesOf3 = 0;
                //foreach (int num in array)
                //{
                //    if (num % 3 == 0)
                //    {
                //        countMultiplesOf3++;
                //    }
                //}
                //Console.WriteLine("Массив:");
                //foreach (int num in array)
                //{
                //    Console.Write(num + " ");
                //}

                //Console.WriteLine("\nКоличество элементов, кратных 3: " + countMultiplesOf3);
                //Console.ReadKey();

                // Дан курс рубля России за январь 2023 года. Рассчитать:
                //а) среднее значение КВ(СКВ);
                //б) максимальное значение КВ(МаксКВ);
                //в) минимальное значение КВ(МинКВ);
                //г) день с максимальным значением КВ(МаксКВД);
                //д) день с минимальным значением КВ(МинКВД).


                //    double[] kurs = {
                //    74.13, 74.45, 74.29, 74.68, 74.85, 75.12, 75.30, 75.47, 75.60, 75.77,
                //    75.90, 76.03, 75.99, 75.85, 75.70, 75.55, 75.39, 75.28, 75.15, 75.05,
                //    74.95, 74.85, 74.70, 74.59, 74.47, 74.35, 74.22, 74.10, 73.98, 73.85,
                //    73.73, 73.60
                //};

                //    double sum = 0;
                //    for (int i = 0; i < kurs.Length; i++)
                //    {
                //        sum += kurs[i];
                //    }
                //    double averageKurs = sum / kurs.Length;

                //    double maxKurs = kurs[0];
                //    int maxKursDay = 1;
                //    for (int i = 1; i < kurs.Length; i++)
                //    {
                //        if (kurs[i] > maxKurs)
                //        {
                //            maxKurs = kurs[i];
                //            maxKursDay = i + 1; 
                //        }
                //    }

                //    double minKurs = kurs[0];
                //    int minKursDay = 1;
                //    for (int i = 1; i < kurs.Length; i++)
                //    {
                //        if (kurs[i] < minKurs)
                //        {
                //            minKurs = kurs[i];
                //            minKursDay = i + 1; 
                //        }
                //    }

                //    Console.WriteLine("а) Среднее значение КВ (СКВ): " + averageKurs);
                //    Console.WriteLine("б) Максимальное значение КВ (МаксКВ): " + maxKurs);
                //    Console.WriteLine("в) Минимальное значение КВ (МинКВ): " + minKurs);
                //    Console.WriteLine("г) День с максимальным значением КВ (МаксКВД): " + maxKursDay);
                //    Console.WriteLine("д) День с минимальным значением КВ (МинКВД): " + minKursDay);
                //    Console.ReadKey();

            }
        }
    }

