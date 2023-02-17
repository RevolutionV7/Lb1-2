using System;

namespace ConsoleApp2
{
    class Program
    {

        delegate int MyDelegate();
        delegate double MyDel(MyDelegate[] a);

        static int GetRandom()
        {
            return new Random().Next(1, 10);
        }


        static void Main()
        {
            Console.WriteLine("Введiть кiлькiсть елементiв масива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 100));

            var array = new MyDelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom)();
            }

            MyDel d = delegate (MyDelegate[] a)
            {
                double sr = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sr += a[i]();
                }
                return sr / array.Length;
            };

            Console.WriteLine("Среднє арифметичне = {0}", d(array));
            Console.WriteLine(new string('-', 100));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]());
            }
        }
    }