using System;

namespace ConsoleApp3
{
    class Program
    {
             static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Среднее арифметическое: " + ((a + b + c) / 3).ToString());
            Console.ReadKey();
        }
        {
            int a, b, c;
            Console.WriteLine("Введите 1 значение");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 значение");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 значение");
            c = Convert.ToInt32(Console.ReadLine());

         
        }
    }
}
