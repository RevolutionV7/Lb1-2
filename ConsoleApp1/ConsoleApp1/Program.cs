using System;

namespace ConsoleApp
{
    public delegate int Delegat(int a, int b);

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть 3 цілі числа.");
            string a = Console.ReadLine();
            Console.WriteLine("а = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c = ");
            int z = Convert.ToInt32(Console.ReadLine());
            {
                case "+":
                    Delegat Delegat = (c, b, a) => { return c + b + a; };
                    int del = Delegat(x, y, z);
                    Console.WriteLine("a+b+c = ", del);
                    break;
                default:
                    Console.WriteLine("Недоступна операцiя");
                    break;
            }

            Console.ReadKey();

        }
    }
}