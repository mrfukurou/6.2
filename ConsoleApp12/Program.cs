using System;

namespace ConsoleApp12
{
    class Program
    {
        static int[] Input()
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Random rand = new Random();
                a[i] = rand.Next(-100, 100);
            }
            return a;
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }


        static void Main()
        {
            try
            {
                Console.Write("Введите число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                int[] myArray = Input();
                Console.WriteLine("Исходный массив:");
                Print(myArray);

                for (int i = 1; i < myArray.Length; i++)
                {
                    if ((myArray[i] - myArray[i - 1]) == num)
                    {
                        count++;

                    }
                }

                if (count > 0) Console.WriteLine("Количество пар: " + count);
                else { Console.WriteLine("Таких пар нет"); }
            }
            catch { Console.WriteLine("Некорректный ввод!"); }
          }

    }
}

